package com.cmic.gen.sdk.e;

import android.content.Context;
import android.database.Cursor;
import android.net.Uri;

/* JADX INFO: compiled from: MeiZuOAID.java */
/* JADX INFO: loaded from: classes2.dex */
public class g extends j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2107a;

    g(Context context) {
        this.f2107a = context;
    }

    @Override // com.cmic.gen.sdk.e.j
    public String a() {
        try {
            Cursor cursorQuery = this.f2107a.getContentResolver().query(Uri.parse("content://com.meizu.flyme.openidsdk/"), null, null, new String[]{"oaid"}, null);
            if (cursorQuery == null) {
                return "";
            }
            cursorQuery.moveToFirst();
            int columnIndex = cursorQuery.getColumnIndex("value");
            String string = columnIndex >= 0 ? cursorQuery.getString(columnIndex) : "";
            cursorQuery.close();
            return string;
        } catch (Throwable unused) {
            return "";
        }
    }
}
