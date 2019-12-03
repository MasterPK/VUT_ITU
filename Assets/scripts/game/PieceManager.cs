using System;
using System.Collections.Generic;
using UnityEngine;

public class PieceManager : MonoBehaviour
{

    public bool mIsStillPiece = true;
    public GameObject mPiecePrefab;

    private List<BasePiece> mWhitePieces = null;
    private List<BasePiece> mBlackPieces = null;
    private List<BasePiece> mPromotedPieces = new List<BasePiece>();

    private string[] mPieceOrder = new string[24]
    {
        "P", "", "P", "", "P", "", "P", "",
        "", "P", "", "P", "", "P", "", "P",
        "P", "", "P", "", "P", "", "P", ""
    };

    private Dictionary<string, Type> mPieceLibrary = new Dictionary<string, Type>()
    {
        {"P",  typeof(Pawn)},
        {"Q",  typeof(Queen)}
    };

    public void Setup(Board board)
    {
        mWhitePieces = CreatePieces(Color.white, new Color32(80, 124, 159, 255), board);
        mBlackPieces = CreatePieces(Color.black, new Color32(210, 95, 64, 255), board);

        PlaceWhitePieces(2, 1, 0, mWhitePieces, board);
        PlaceBlackPieces(5,6,7, mBlackPieces, board);

        SwitchSides(Color.black);
    }

    private List<BasePiece> CreatePieces(Color teamColor, Color32 spriteColor, Board board)
    {
        List<BasePiece> newPieces = new List<BasePiece>();

        for (int i = 0; i < mPieceOrder.Length; i++)
        {
            string key = mPieceOrder[i];
            if (key == "")
            {
                continue;
            }

            GameObject newPieceObject = Instantiate(mPiecePrefab);
            newPieceObject.transform.SetParent(transform);

            newPieceObject.transform.localScale = new Vector3(1, 1, 1);
            newPieceObject.transform.localRotation = Quaternion.identity;


            Type pieceType = mPieceLibrary[key];

            BasePiece newPiece = (BasePiece)newPieceObject.AddComponent(pieceType);
            newPieces.Add(newPiece);

            newPiece.Setup(teamColor, spriteColor, this);
        }

        return newPieces;
    }

    private BasePiece CreatePiece(Type pieceType)
    {
        return null;
    }

    private void PlaceWhitePieces(int pawnRow, int pawnRow1, int pawnRow2, List<BasePiece> pieces, Board board)
    {
            pieces[0].Place(board.mAllCells[0, pawnRow]);
            pieces[1].Place(board.mAllCells[2, pawnRow]);
            pieces[2].Place(board.mAllCells[4, pawnRow]);
            pieces[3].Place(board.mAllCells[6, pawnRow]);
            pieces[4].Place(board.mAllCells[1, pawnRow1]);
            pieces[5].Place(board.mAllCells[3, pawnRow1]);
            pieces[6].Place(board.mAllCells[5, pawnRow1]);
            pieces[7].Place(board.mAllCells[7, pawnRow1]);
            pieces[8].Place(board.mAllCells[0, pawnRow2]);
            pieces[9].Place(board.mAllCells[2, pawnRow2]);
            pieces[10].Place(board.mAllCells[4, pawnRow2]);
            pieces[11].Place(board.mAllCells[6, pawnRow2]);
    }

    private void PlaceBlackPieces(int pawnRow, int pawnRow1, int pawnRow2, List<BasePiece> pieces, Board board)
    {
        pieces[0].Place(board.mAllCells[1, pawnRow]);
        pieces[1].Place(board.mAllCells[3, pawnRow]);
        pieces[2].Place(board.mAllCells[5, pawnRow]);
        pieces[3].Place(board.mAllCells[7, pawnRow]);
        pieces[4].Place(board.mAllCells[0, pawnRow1]);
        pieces[5].Place(board.mAllCells[2, pawnRow1]);
        pieces[6].Place(board.mAllCells[4, pawnRow1]);
        pieces[7].Place(board.mAllCells[6, pawnRow1]);
        pieces[8].Place(board.mAllCells[1, pawnRow2]);
        pieces[9].Place(board.mAllCells[3, pawnRow2]);
        pieces[10].Place(board.mAllCells[5, pawnRow2]);
        pieces[11].Place(board.mAllCells[7, pawnRow2]);
    }

    private void SetInteractive(List<BasePiece> allPieces, bool value)
    {
        foreach (BasePiece piece in allPieces)
            piece.enabled = value;
    }

    public void SwitchSides(Color color)
    {
        if(!mIsStillPiece)
        {
            ResetPieces();

            mIsStillPiece = true;

            color = Color.black;
        }

        bool isBlackTurn = color == Color.white ? true : false;

        SetInteractive(mWhitePieces, !isBlackTurn);
        SetInteractive(mBlackPieces, isBlackTurn);

    }

    public void ResetPieces()
    {
        foreach (BasePiece piece in mWhitePieces)
            piece.Reset();

        foreach (BasePiece piece in mBlackPieces)
            piece.Reset();
    }

    public void PromotePiece(Pawn pawn, Cell cell, Color teamColor, Color spriteColor)
    {

    }
}
