package com.cmic.gen.sdk.e;

import android.content.ContentResolver;
import android.content.Context;
import android.database.Cursor;
import android.net.Uri;

/* JADX INFO: compiled from: VivoOAID.java */
/* JADX INFO: loaded from: classes2.dex */
public class n extends j {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2114a;

    n(Context context) {
        this.f2114a = context;
    }

    @Override // com.cmic.gen.sdk.e.j
    public String a() {
        Uri uri = Uri.parse("content://com.vivo.vms.IdProvider/IdentifierId/OAID");
        ContentResolver contentResolver = this.f2114a.getContentResolver();
        String string = "";
        if (contentResolver == null) {
            return "";
        }
        Cursor cursorQuery = contentResolver.query(uri, null, null, null, null);
        if (cursorQuery != null) {
            cursorQuery.moveToNext();
            int columnIndex = cursorQuery.getColumnIndex("value");
            string = columnIndex >= 0 ? cursorQuery.getString(columnIndex) : "";
            cursorQuery.close();
        }
        return string;
    }
}
