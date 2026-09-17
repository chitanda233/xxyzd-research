package com.byazt.kh;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 432, 13})
public abstract class tt implements Runnable {
    public final String tt;

    public abstract void ve();

    public tt(String str, Object... objArr) {
        this.tt = ve.c(str, objArr);
    }

    @Override // java.lang.Runnable
    public final void run() {
        String name = Thread.currentThread().getName();
        Thread.currentThread().setName("csj_" + this.tt);
        try {
            ve();
        } finally {
            Thread.currentThread().setName(name);
        }
    }
}
