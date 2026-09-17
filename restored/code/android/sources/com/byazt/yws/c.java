package com.byazt.yws;

import android.content.Context;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 866, 20})
public class c extends tt {
    public static volatile c c;

    public static c c(Context context) {
        if (c == null) {
            synchronized (c.class) {
                if (c == null) {
                    c = new c(context);
                }
            }
        }
        return c;
    }

    private c(Context context) {
        super(context, "ttopensdk2.db");
    }
}
