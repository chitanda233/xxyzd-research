package com.byazt.cf;

import android.content.Context;
import com.byazt.omf.gt;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 18, 91})
public class sp extends ve {
    public static final sp ve = new sp(gt.getContext());

    @Override // com.byazt.cf.ve
    public int tt() {
        return 7;
    }

    private sp(Context context) {
        super(context);
    }

    public static sp c() {
        return ve;
    }

    public void c(com.byazt.dj.tt ttVar, String str, int i, uj ujVar) {
        com.byazt.cjm.ve veVar = new com.byazt.cjm.ve();
        veVar.c(str);
        veVar.c(i + 1);
        c(ttVar, ujVar, veVar, null, null, null);
    }
}
