package ms.bz.bd.c.Pgl;

import android.content.Context;

/* JADX INFO: loaded from: classes4.dex */
public final class pblw {
    private static final pblw c = new pblw();
    private Context tt;

    public static pblw c() {
        return c;
    }

    public final void c(Context context) {
        this.tt = context != null ? context.getApplicationContext() : null;
    }

    public final Context tt() {
        return this.tt;
    }
}
