package com.byazt.lx;

import android.util.SparseArray;
import androidx.core.view.PointerIconCompat;
import java.util.function.Function;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, PointerIconCompat.TYPE_GRABBING, 20})
public class c implements Function<SparseArray<Object>, Object> {
    public static volatile c c;
    public static Function<SparseArray<Object>, Object> tt;

    @Override // java.util.function.Function
    public Object apply(SparseArray<Object> sparseArray) {
        return null;
    }

    public static void init(Function<SparseArray<Object>, Object> function) {
        tt = function;
    }

    public static c getInstance() {
        if (c == null) {
            synchronized (c.class) {
                if (c == null) {
                    c = new c();
                }
            }
        }
        return c;
    }

    private c() {
    }

    public void startRequestRit(String str, String str2) {
        if (tt != null) {
            com.byazt.rl.c cVarC = com.byazt.rl.c.c();
            cVarC.c(20000, str);
            cVarC.c(20001, str2);
            cVarC.c(-99999987, 10000);
            cVarC.c(-99999985, Void.class);
            tt.apply(cVarC.tt().sparseArray());
        }
    }
}
