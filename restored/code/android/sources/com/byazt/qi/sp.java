package com.byazt.qi;

import android.content.Context;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 527, 91})
public class sp {
    public Context c;
    public x n;
    public String tt;
    public boolean uj;
    public String ve;

    public Context c() {
        return this.c;
    }

    public String tt() {
        return this.tt;
    }

    public boolean ve() {
        return this.uj;
    }

    public x uj() {
        return this.n;
    }

    @com.byazt.zqa.c(c = {0, 1, 527, 180})
    public static class c {
        public final Context c;
        public final String tt;
        public final String ve;
        public boolean uj = false;
        public x n = null;

        public c(Context context, String str, String str2) {
            this.c = context;
            this.ve = str2;
            this.tt = str;
        }

        public void c(x xVar) {
            this.n = xVar;
        }

        public c c(boolean z) {
            this.uj = z;
            return this;
        }

        public sp c() {
            sp spVar = new sp();
            spVar.c = this.c;
            spVar.tt = this.tt;
            spVar.ve = this.ve;
            spVar.n = this.n;
            spVar.uj = this.uj;
            return spVar;
        }
    }
}
