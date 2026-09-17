package com.bytedance.ads.convert.flat.m;

import android.content.Context;
import android.content.pm.PackageManager;
import android.database.Cursor;
import android.net.Uri;

/* JADX INFO: loaded from: classes2.dex */
public final class i implements com.bytedance.ads.convert.flat.k.c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public com.bytedance.ads.convert.flat.n.c<Boolean> f1736a = new a(this);

    public class a extends com.bytedance.ads.convert.flat.n.c<Boolean> {
        public a(i iVar) {
        }

        @Override // com.bytedance.ads.convert.flat.n.c
        public Boolean a(Object[] objArr) {
            try {
                PackageManager packageManager = ((Context) objArr[0]).getPackageManager();
                if (packageManager != null) {
                    return Boolean.valueOf(packageManager.resolveContentProvider("com.meizu.flyme.openidsdk", 0) != null);
                }
            } catch (Exception unused) {
            }
            return Boolean.FALSE;
        }
    }

    /* JADX WARN: Code duplicated, block: B:10:0x002b  */
    @Override // com.bytedance.ads.convert.flat.k.c
    public com.bytedance.ads.convert.flat.k.c.a a(Context context) {
        Cursor cursorQuery;
        String string;
        try {
            cursorQuery = context.getContentResolver().query(Uri.parse("content://com.meizu.flyme.openidsdk/"), null, null, new String[]{"oaid"}, null);
            if (cursorQuery == null) {
                if (cursorQuery != null) {
                    cursorQuery.close();
                }
                return null;
            }
            try {
                com.bytedance.ads.convert.flat.k.c.a aVar = new com.bytedance.ads.convert.flat.k.c.a();
                if (cursorQuery.isClosed()) {
                    string = null;
                } else {
                    cursorQuery.moveToFirst();
                    int columnIndex = cursorQuery.getColumnIndex("value");
                    if (columnIndex >= 0) {
                        string = cursorQuery.getString(columnIndex);
                    } else {
                        string = null;
                    }
                }
                aVar.f1727a = string;
                cursorQuery.close();
                return aVar;
            } catch (Throwable th) {
                th = th;
                try {
                    th.printStackTrace();
                    return null;
                } finally {
                    if (cursorQuery != null) {
                        cursorQuery.close();
                    }
                }
            }
        } catch (Throwable th2) {
            th = th2;
            cursorQuery = null;
        }
    }

    @Override // com.bytedance.ads.convert.flat.k.c
    public boolean b(Context context) {
        if (context == null) {
            return false;
        }
        return this.f1736a.b(context).booleanValue();
    }
}
