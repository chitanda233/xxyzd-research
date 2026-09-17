package com.byazt.ue;

import com.byazt.omf.gt;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 1265, 46})
public class n {
    public static String c = "com.bytedance.openadsdk";
    public static String tt = "content://" + c + ".TTMultiProvider";

    static {
        c();
    }

    public static void c() {
        if (gt.getContext() != null) {
            c = gt.getContext().getPackageName();
            tt = "content://" + c + ".TTMultiProvider";
        }
    }
}
