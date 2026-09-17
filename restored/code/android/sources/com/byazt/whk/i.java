package com.byazt.whk;

import android.util.SparseArray;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 908, 42})
public class i {
    public int c;
    public com.byazt.yxi.tt tt;
    public SparseArray<Object> ve;

    public i(SparseArray<Object> sparseArray, int i) {
        this.c = i;
        this.ve = sparseArray != null ? sparseArray : new SparseArray<>();
        this.tt = new com.byazt.yxi.tt(sparseArray);
    }

    public int getType() {
        return this.c;
    }

    public com.byazt.yxi.tt ve() {
        return this.tt;
    }

    public SparseArray<Object> uj() {
        return this.ve;
    }

    public void setResult(SparseArray<Object> sparseArray) {
        this.tt = new com.byazt.yxi.tt(sparseArray);
    }
}
