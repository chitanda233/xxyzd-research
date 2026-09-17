package com.bytedance.ads.convert.flat.m;

import android.content.Context;
import android.database.Cursor;
import android.net.Uri;
import android.os.SystemProperties;

/* JADX INFO: loaded from: classes2.dex */
public final class k implements com.bytedance.ads.convert.flat.k.c {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final com.bytedance.ads.convert.flat.n.c<Boolean> f1737a = new a();

    public static class a extends com.bytedance.ads.convert.flat.n.c<Boolean> {
        @Override // com.bytedance.ads.convert.flat.n.c
        public Boolean a(Object[] objArr) {
            return Boolean.valueOf("1".equals(k.a(com.alipay.sdk.m.u0.c.c, "0")));
        }
    }

    public static String a(String str, String str2) {
        try {
            return SystemProperties.get(str, str2);
        } catch (Throwable unused) {
            return str2;
        }
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r3v10 */
    /* JADX WARN: Type inference failed for: r3v2 */
    /* JADX WARN: Type inference failed for: r3v3, types: [android.database.Cursor] */
    @Override // com.bytedance.ads.convert.flat.k.c
    public com.bytedance.ads.convert.flat.k.c.a a(Context context) throws Throwable {
        Cursor cursorQuery;
        StringBuilder sb;
        com.bytedance.ads.convert.flat.k.c.a aVar = new com.bytedance.ads.convert.flat.k.c.a();
        Uri uri = Uri.parse("content://com.vivo.vms.IdProvider/IdentifierId/OAID");
        String string = null;
        string = null;
        string = null;
        string = null;
        string = null;
        string = null;
        ?? r3 = 0;
        try {
            if (uri != null) {
                try {
                    cursorQuery = context.getContentResolver().query(uri, null, null, null, null);
                    if (cursorQuery != null) {
                        try {
                            if (cursorQuery.moveToNext()) {
                                string = cursorQuery.getString(cursorQuery.getColumnIndex("value"));
                            }
                        } catch (Exception e) {
                            e = e;
                            String str = "OaidVivo# query error: " + e.getMessage();
                            if (cursorQuery != null) {
                                try {
                                    cursorQuery.close();
                                } catch (Exception e2) {
                                    e = e2;
                                    sb = new StringBuilder("OaidVivo#query close cursor exception.");
                                    sb.append(e.getMessage()).toString();
                                }
                            }
                        }
                    }
                    if (cursorQuery != null) {
                        try {
                            cursorQuery.close();
                        } catch (Exception e3) {
                            e = e3;
                            sb = new StringBuilder("OaidVivo#query close cursor exception.");
                            sb.append(e.getMessage()).toString();
                        }
                    }
                } catch (Exception e4) {
                    e = e4;
                    cursorQuery = null;
                } catch (Throwable th) {
                    th = th;
                    if (r3 != 0) {
                        try {
                            r3.close();
                        } catch (Exception e5) {
                            String str2 = "OaidVivo#query close cursor exception." + e5.getMessage();
                        }
                    }
                    throw th;
                }
            }
            aVar.f1727a = string;
            return aVar;
        } catch (Throwable th2) {
            th = th2;
            r3 = context;
        }
    }

    @Override // com.bytedance.ads.convert.flat.k.c
    public boolean b(Context context) {
        return f1737a.b(new Object[0]).booleanValue();
    }
}
