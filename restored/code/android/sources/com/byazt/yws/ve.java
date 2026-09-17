package com.byazt.yws;

import android.content.Context;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 866, 54})
public class ve extends tt {
    public static volatile ve c;

    public static ve c(Context context) {
        if (c == null) {
            synchronized (ve.class) {
                if (c == null) {
                    c = new ve(context);
                }
            }
        }
        return c;
    }

    private ve(Context context) {
        super(context, "ttopensdk.db");
    }
}
