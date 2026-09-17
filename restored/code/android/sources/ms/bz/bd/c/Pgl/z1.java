package ms.bz.bd.c.Pgl;

import android.content.Context;
import android.database.Cursor;
import android.net.Uri;

/* JADX INFO: loaded from: classes4.dex */
public final class z1 {
    private final Context c;

    public z1(Context context) {
        this.c = context;
    }

    /* JADX WARN: Code duplicated, block: B:27:0x007d A[DONT_GENERATE, EXC_TOP_SPLITTER, PHI: r1
  0x007d: PHI (r1v5 java.lang.String) = (r1v3 java.lang.String), (r1v2 java.lang.String) binds: [B:16:0x0086, B:10:0x0069] A[DONT_GENERATE, DONT_INLINE], SYNTHETIC] */
    public final String c() {
        Cursor cursorQuery = this.c.getContentResolver().query(Uri.parse((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "2f664b", new byte[]{32, 107, 75, 86, 14, 123, 37, 29, 40, 41, 32, 107, 72, 12, 29, 124, 39, 72, 41, 112, 46, 119, 11, 107, 15, 69, 35, 72, 113, 111, 39, 97, 87, 13, 34, 113, com.sigmob.sdk.archives.tar.e.L, 73, 115, 111, 37, 109, 64, 80, 34, 113, 126, 104, 70, 79, 7})), null, null, null, null);
        String string = null;
        if (cursorQuery != null) {
            try {
                if (cursorQuery.moveToNext()) {
                    string = cursorQuery.getString(cursorQuery.getColumnIndex((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "dac80a", new byte[]{99, 98, 28, 89, 10})));
                }
                if (cursorQuery != null) {
                }
            } catch (Throwable unused) {
                try {
                    com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "14b615", new byte[]{com.sigmob.sdk.archives.tar.e.N, 57});
                } finally {
                    try {
                        cursorQuery.close();
                    } catch (Throwable unused2) {
                    }
                }
            }
        } else if (cursorQuery != null) {
        }
        return string;
    }
}
