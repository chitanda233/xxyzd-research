package com.tencent.turingfd.sdk.ams.ad;

import android.util.SparseArray;

/* JADX INFO: loaded from: classes4.dex */
public abstract class Cantaloupe {
    public static Object a(SparseArray sparseArray, int i, Class cls) {
        if (sparseArray == null) {
            return null;
        }
        Object obj = sparseArray.get(i);
        if (cls.isInstance(obj)) {
            return cls.cast(obj);
        }
        return null;
    }

    public static int a(SparseArray sparseArray) {
        Integer num = (Integer) a(sparseArray, 0, Integer.class);
        if (num == null) {
            return -1;
        }
        return num.intValue();
    }
}
