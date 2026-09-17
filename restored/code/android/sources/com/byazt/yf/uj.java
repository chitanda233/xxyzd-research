package com.byazt.yf;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 508, 15})
public class uj {
    public String c;

    private uj(c cVar) {
        this.c = cVar.c;
    }

    @com.byazt.zqa.c(c = {0, 1, 508, 123})
    public static class c {
        public String c;

        public uj c() {
            return new uj(this);
        }
    }

    public String c() {
        return this.c;
    }
}
