package com.byazt.ah;

import androidx.core.view.PointerIconCompat;
import java.util.LinkedList;
import java.util.List;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, PointerIconCompat.TYPE_HORIZONTAL_DOUBLE_ARROW, 13})
public class tt extends com.byazt.sbm.uj {
    @Override // com.byazt.sbm.uj
    public void destroy() {
    }

    @Override // com.byazt.sbm.ve
    public boolean isReady() {
        return true;
    }

    @Override // com.byazt.sbm.ve
    public List<com.byazt.sbm.tt> getAdLoadInfo() {
        return new LinkedList();
    }

    @Override // com.byazt.sbm.ve
    public List<com.byazt.sbm.c> getMultiBiddingEcpm() {
        return new LinkedList();
    }

    @Override // com.byazt.sbm.ve
    public com.byazt.sbm.c getBestEcpm() {
        return new c();
    }

    @Override // com.byazt.sbm.ve
    public List<com.byazt.sbm.c> getCacheList() {
        return new LinkedList();
    }

    @Override // com.byazt.sbm.ve
    public com.byazt.sbm.c getShowEcpm() {
        return new c();
    }
}
