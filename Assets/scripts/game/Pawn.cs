using UnityEngine;
using UnityEngine.UI;

public class Pawn : BasePiece
{
    public override void Setup(Color newTeamColor, Color32 newSpriteColor, PieceManager newPieceManager)
    {
        base.Setup(newTeamColor, newSpriteColor, newPieceManager);

        mMovement = mColor == Color.white ? new Vector3Int(0, 1, 1) : new Vector3Int(0, -1, -1);
        GetComponent<Image>().sprite = Resources.Load<Sprite>("T_Pawn");
 
    }

    protected override void Move()
    {
        base.Move();

    }
    private bool MatchesState(int targetX, int targetY, CellState targetState)
    {
        CellState cellState = CellState.None;
        cellState = mCurrentCell.mBoard.ValidateCell(targetX, targetY, this);

        if(cellState == targetState)
        {
            mHighlightedCells.Add(mCurrentCell.mBoard.mAllCells[targetX, targetY]);
            return true;
        }
        return false;
    }

    protected override void CheckPathing()
    {
        int curentX = mCurrentCell.mBoardPosition.x;
        int curentY = mCurrentCell.mBoardPosition.y;

        MatchesState(curentX - mMovement.z, curentY + mMovement.z, CellState.Free);

        //MatchesState(curentX, curentY + mMovement.y, CellState.Free);

        MatchesState(curentX + mMovement.z, curentY + mMovement.z, CellState.Free);
    }
}
