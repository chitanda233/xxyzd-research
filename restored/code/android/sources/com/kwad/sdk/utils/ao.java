package com.kwad.sdk.utils;

import android.content.Context;
import android.database.Cursor;
import android.net.Uri;
import android.text.TextUtils;

/* JADX INFO: loaded from: classes3.dex */
public final class ao {
    private static String bpD;
    private static boolean bpE;

    public static String dw(Context context) {
        Cursor cursorQuery;
        if (!TextUtils.isEmpty(bpD) || bpE || !bd.Wk()) {
            return bpD;
        }
        try {
            cursorQuery = context.getContentResolver().query(Uri.parse("content://com.xiaomi.market.provider.DirectMailProvider"), null, null, null, null);
            try {
                bpD = j(cursorQuery);
            } catch (Throwable unused) {
            }
        } catch (Throwable unused2) {
            cursorQuery = null;
        }
        com.kwad.sdk.crash.utils.b.closeQuietly(cursorQuery);
        bpE = TextUtils.isEmpty(bpD);
        return bpD;
    }

    private static String j(Cursor cursor) {
        int columnIndex;
        if (cursor == null || cursor.isClosed()) {
            com.kwad.sdk.core.d.c.i("MiMarketHelper", "cursor is null");
            return "";
        }
        cursor.moveToFirst();
        int columnIndex2 = cursor.getColumnIndex("support");
        return ((columnIndex2 <= 0 || cursor.getInt(columnIndex2) != 0) && (columnIndex = cursor.getColumnIndex("detailStyle")) > 0) ? cursor.getString(columnIndex) : "";
    }

    public static boolean dx(Context context) {
        Cursor cursorQuery;
        boolean zK = false;
        if (!bd.Wk()) {
            return false;
        }
        try {
            cursorQuery = context.getContentResolver().query(Uri.parse("content://com.xiaomi.market.provider.DirectMailProvider"), null, null, null, null);
            try {
                zK = k(cursorQuery);
            } catch (Throwable unused) {
                try {
                    com.kwad.sdk.core.d.c.e("MiMarketHelper", "isSupportMiMarket2 failed");
                } catch (Throwable th) {
                    com.kwad.sdk.crash.utils.b.closeQuietly(cursorQuery);
                    throw th;
                }
            }
        } catch (Throwable unused2) {
            cursorQuery = null;
        }
        com.kwad.sdk.crash.utils.b.closeQuietly(cursorQuery);
        if (!zK && bd.Wk()) {
            com.kwad.sdk.core.d.c.i("MiMarketHelper", "is Miui but not support MiMarket2.0");
        }
        return zK;
    }

    private static boolean k(Cursor cursor) {
        if (cursor == null || cursor.isClosed()) {
            com.kwad.sdk.core.d.c.i("MiMarketHelper", "isSupportMiMarket2: cursor is null");
            return false;
        }
        cursor.moveToFirst();
        int columnIndex = cursor.getColumnIndex("support");
        if (columnIndex >= 0) {
            return cursor.getString(columnIndex).equals("true");
        }
        return false;
    }

    public static boolean hO(String str) {
        return str.startsWith("market://details") || str.startsWith("mimarket://details");
    }
}
