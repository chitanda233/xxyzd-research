package com.czhj.devicehelper.cnoaid.impl;

import android.content.Context;
import android.database.Cursor;
import android.net.Uri;
import android.os.Build;
import java.util.Objects;

/* JADX INFO: loaded from: classes2.dex */
class s implements com.czhj.devicehelper.cnoaid.d {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final Context f2215a;

    public s(Context context) {
        this.f2215a = context;
    }

    @Override // com.czhj.devicehelper.cnoaid.d
    public void a(com.czhj.devicehelper.cnoaid.c cVar) {
        if (this.f2215a == null || cVar == null) {
            return;
        }
        try {
            Cursor cursorQuery = this.f2215a.getContentResolver().query(Uri.parse("content://com.vivo.vms.IdProvider/IdentifierId/OAID"), null, null, null, null);
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
        if (Build.VERSION.SDK_INT < 28) {
            return false;
        }
        return com.czhj.devicehelper.cnoaid.h.a(com.alipay.sdk.m.u0.c.c, "0").equals("1");
    }
}
