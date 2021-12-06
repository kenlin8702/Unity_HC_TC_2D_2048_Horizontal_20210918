
using UnityEngine;

public class BlockData {

    public GameObject goBlocks;
    public Vector2 v2Position;
    public Vector2Int v2Index;
    public int number;
    public BlockData() {

    }

    public void chnageBlockValue(BlockData b) {
        goBlocks = b.goBlocks;
        number = b.number;
    }
    public void clearBlockValue() {
        goBlocks = null;
        number = 0;
    }
}
