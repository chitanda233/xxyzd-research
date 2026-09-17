package a.d.a.a;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.IntentFilter;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.content.pm.ProviderInfo;
import android.database.Cursor;
import android.net.Uri;
import android.text.TextUtils;
import com.byazt.nys.PluginConstants;

/* JADX INFO: loaded from: classes.dex */
public class e {
    public static volatile e g;
    public BroadcastReceiver f;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public a f26a = new a("udid");
    public a b = new a("oaid");
    public a d = new a("vaid");
    public a c = new a("aaid");
    public b e = new b();

    public static c a(Cursor cursor) {
        c cVar = new c(null, 0);
        if (cursor == null || cursor.isClosed()) {
            return cVar;
        }
        cursor.moveToFirst();
        int columnIndex = cursor.getColumnIndex("value");
        if (columnIndex >= 0) {
            cVar.f25a = cursor.getString(columnIndex);
        }
        int columnIndex2 = cursor.getColumnIndex(PluginConstants.KEY_ERROR_CODE);
        if (columnIndex2 >= 0) {
            cVar.b = cursor.getInt(columnIndex2);
        }
        int columnIndex3 = cursor.getColumnIndex("expired");
        if (columnIndex3 >= 0) {
            cVar.c = cursor.getLong(columnIndex3);
        }
        return cVar;
    }

    public static final e a() {
        if (g == null) {
            synchronized (e.class) {
                if (g == null) {
                    g = new e();
                }
            }
        }
        return g;
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r1v0 */
    /* JADX WARN: Type inference failed for: r1v1 */
    /* JADX WARN: Type inference failed for: r1v11 */
    /* JADX WARN: Type inference failed for: r1v16 */
    /* JADX WARN: Type inference failed for: r1v19 */
    /* JADX WARN: Type inference failed for: r1v2, types: [android.database.Cursor] */
    /* JADX WARN: Type inference failed for: r1v20 */
    /* JADX WARN: Type inference failed for: r1v21 */
    /* JADX WARN: Type inference failed for: r1v4 */
    /* JADX WARN: Type inference failed for: r1v5 */
    /* JADX WARN: Type inference failed for: r1v6, types: [java.lang.String] */
    /* JADX WARN: Type inference failed for: r1v7 */
    /* JADX WARN: Type inference failed for: r1v8 */
    public final String a(Context context, a aVar) throws Throwable {
        String str;
        boolean zA;
        StringBuilder sb;
        String str2;
        String str3;
        ?? r1 = 0;
        str = null;
        r1 = 0;
        String str4 = null;
        Cursor cursor = null;
        if (aVar == null) {
            return null;
        }
        if (aVar.f23a > System.currentTimeMillis()) {
            return aVar.b;
        }
        if (!a(context, true)) {
            return null;
        }
        String str5 = "queryId : " + aVar.c;
        try {
            try {
                Cursor cursorQuery = context.getContentResolver().query(Uri.parse("content://com.meizu.flyme.openidsdk/"), null, null, new String[]{aVar.c}, null);
                try {
                    if (cursorQuery == null) {
                        if (a(context, false)) {
                            zA = a(context, true);
                            sb = new StringBuilder();
                            str2 = "forceQuery isSupported : ";
                            sb.append(str2).append(zA).toString();
                            r1 = str4;
                        }
                        return r1;
                    }
                    c cVarA = a(cursorQuery);
                    str3 = cVarA.f25a;
                    aVar.b = str3;
                    aVar.f23a = cVarA.c;
                    aVar.d = cVarA.b;
                    String str6 = aVar.c + " errorCode : " + aVar.d;
                    if (cVarA.b != 1000) {
                        a(context);
                        if (!a(context, false)) {
                            r1 = str3;
                            r1 = str3;
                            zA = a(context, true);
                            sb = new StringBuilder();
                            str2 = "not support, forceQuery isSupported: ";
                            str4 = str3;
                            sb.append(str2).append(zA).toString();
                            r1 = str4;
                        }
                        return r1;
                    }
                    if (cursorQuery != null) {
                        cursorQuery.close();
                    }
                } catch (Exception e) {
                    e = e;
                    str = str4;
                    cursor = cursorQuery;
                    String str7 = "queryId, Exception : " + e.getMessage();
                    if (cursor != null) {
                        cursorQuery = cursor;
                        r1 = str;
                    } else {
                        r1 = str;
                    }
                    return r1;
                } catch (Throwable th) {
                    th = th;
                    r1 = cursorQuery;
                    if (r1 != 0) {
                        r1.close();
                    }
                    throw th;
                }
            } catch (Throwable th2) {
                th = th2;
            }
        } catch (Exception e2) {
            e = e2;
            str = null;
        }
        return r1;
    }

    public final synchronized void a(Context context) {
        if (this.f != null) {
            return;
        }
        IntentFilter intentFilter = new IntentFilter();
        intentFilter.addAction("com.meizu.flyme.openid.ACTION_OPEN_ID_CHANGE");
        d dVar = new d();
        this.f = dVar;
        context.registerReceiver(dVar, intentFilter, "com.meizu.flyme.openid.permission.OPEN_ID_CHANGE", null);
    }

    /* JADX WARN: Code duplicated, block: B:67:0x00ed A[PHI: r2
  0x00ed: PHI (r2v7 android.database.Cursor) = (r2v6 android.database.Cursor), (r2v8 android.database.Cursor) binds: [B:66:0x00eb, B:60:0x00d5] A[DONT_GENERATE, DONT_INLINE]] */
    public final boolean a(Context context, boolean z) {
        String str;
        boolean z2 = true;
        boolean z3 = false;
        if ((this.e.b != null) && !z) {
            Boolean bool = this.e.b;
            if (bool != null) {
                return bool.booleanValue();
            }
            return false;
        }
        PackageManager packageManager = context.getPackageManager();
        if (packageManager == null) {
            return false;
        }
        Cursor cursorQuery = null;
        try {
            PackageInfo packageInfo = packageManager.getPackageInfo("com.meizu.safe", 0);
            str = packageInfo != null ? packageInfo.versionName : null;
        } catch (Exception e) {
            e.printStackTrace();
            String str2 = "getAppVersion, Exception : " + e.getMessage();
        }
        if (this.e.b != null) {
            b bVar = this.e;
            bVar.getClass();
            if (TextUtils.isEmpty(str) ? false : TextUtils.equals(bVar.f24a, str)) {
                String str3 = "use same version cache, safeVersion : " + str;
                Boolean bool2 = this.e.b;
                if (bool2 != null) {
                    return bool2.booleanValue();
                }
                return false;
            }
        }
        this.e.f24a = str;
        ProviderInfo providerInfoResolveContentProvider = packageManager.resolveContentProvider("com.meizu.flyme.openidsdk", 0);
        if ((providerInfoResolveContentProvider == null || (providerInfoResolveContentProvider.applicationInfo.flags & 1) == 0 || !TextUtils.equals("com.meizu.safe", providerInfoResolveContentProvider.packageName)) ? false : true) {
            try {
                try {
                    cursorQuery = context.getContentResolver().query(Uri.parse("content://com.meizu.flyme.openidsdk/"), null, null, new String[]{"supported"}, null);
                    if (cursorQuery != null) {
                        c cVarA = a(cursorQuery);
                        if (1000 == cVarA.b && !"0".equals(cVarA.f25a)) {
                            z2 = false;
                        }
                        cursorQuery.close();
                        z3 = z2;
                    } else if (cursorQuery != null) {
                        cursorQuery.close();
                    }
                } catch (Exception e2) {
                    String str4 = "querySupport, Exception : " + e2.getMessage();
                    if (cursorQuery != null) {
                        cursorQuery.close();
                    }
                }
                String str5 = "query support, result : " + z3;
                this.e.b = Boolean.valueOf(z3);
                return z3;
            } catch (Throwable th) {
                if (cursorQuery != null) {
                    cursorQuery.close();
                }
                throw th;
            }
        }
        this.e.b = false;
        return false;
    }
}
