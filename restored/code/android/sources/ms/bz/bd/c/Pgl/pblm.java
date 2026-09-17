package ms.bz.bd.c.Pgl;

import android.content.Context;
import android.util.DisplayMetrics;

/* JADX INFO: loaded from: classes4.dex */
public final class pblm {
    private static int c;

    public static String c(Context context) {
        if (context != null) {
            try {
                new DisplayMetrics();
                c = context.getResources().getDisplayMetrics().densityDpi;
            } catch (Throwable unused) {
            }
        }
        return "" + c;
    }
}
