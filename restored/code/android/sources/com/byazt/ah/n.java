package com.byazt.ah;

import androidx.core.view.PointerIconCompat;
import com.byazt.sbm.sp;
import java.util.LinkedList;
import java.util.List;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, PointerIconCompat.TYPE_HORIZONTAL_DOUBLE_ARROW, 46})
public class n extends sp {
    @Override // com.byazt.sbm.sp
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
    public c getBestEcpm() {
        return new c();
    }

    @Override // com.byazt.sbm.ve
    public List<com.byazt.sbm.c> getCacheList() {
        return new LinkedList();
    }

    @Override // com.byazt.sbm.ve
    public c getShowEcpm() {
        return new c();
    }
}
