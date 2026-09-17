package com.czhj.devicehelper.cnoaid.impl;

import android.content.Context;
import android.database.Cursor;
import android.net.Uri;
import java.util.Objects;

/* JADX INFO: loaded from: classes2.dex */
class j implements com.czhj.devicehelper.cnoaid.d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2201a;

    public j(Context context) {
        this.f2201a = context;
    }

    @Override // com.czhj.devicehelper.cnoaid.d
    public void a(com.czhj.devicehelper.cnoaid.c cVar) {
        if (this.f2201a == null || cVar == null) {
            return;
        }
        try {
            Cursor cursorQuery = this.f2201a.getContentResolver().query(Uri.parse("content://com.meizu.flyme.openidsdk/"), null, null, new String[]{"oaid"}, null);
            try {
                ((Cursor) Objects.requireNonNull(cursorQuery)).moveToFirst();
                String string = cursorQuery.getString(cursorQuery.getColumnIndex("value"));
                if (string == null || string.length() == 0) {
                    throw new com.czhj.devicehelper.cnoaid.f("OAID query failed");
                }
                com.czhj.devicehelper.cnoaid.g.a("OAID query success: " + string);
                cVar.a(string);
                if (cursorQuery != null) {
                    cursorQuery.close();
                }
            } catch (Throwable th) {
                if (cursorQuery != null) {
                    try {
                        cursorQuery.close();
                    } catch (Throwable th2) {
                        th.addSuppressed(th2);
                    }
                }
                throw th;
            }
        } catch (Exception e) {
            com.czhj.devicehelper.cnoaid.g.a(e);
            cVar.a(e);
        }
    }

    @Override // com.czhj.devicehelper.cnoaid.d
    public boolean a() {
        Context context = this.f2201a;
        if (context == null) {
            return false;
        }
        try {
            return context.getPackageManager().resolveContentProvider("com.meizu.flyme.openidsdk", 0) != null;
        } catch (Exception e) {
            com.czhj.devicehelper.cnoaid.g.a(e);
            return false;
        }
    }
}
