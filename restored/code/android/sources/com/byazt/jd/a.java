package com.byazt.jd;

import android.content.Context;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 1500, 34})
public class a extends sp {
    public static volatile a c;

    public static a c(Context context) {
        if (c == null) {
            synchronized (a.class) {
                if (c == null) {
                    c = new a(context);
                }
            }
        }
        return c;
    }

    private a(Context context) {
        super(context);
    }
}
