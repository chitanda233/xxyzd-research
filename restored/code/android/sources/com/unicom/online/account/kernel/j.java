package com.unicom.online.account.kernel;

import android.content.Context;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import com.sigmob.sdk.base.mta.PointCategory;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public abstract class j {
    public static String b = "";

    /* JADX WARN: Code duplicated, block: B:14:0x002e  */
    /* JADX WARN: Code duplicated, block: B:15:0x002f A[Catch: JSONException -> 0x006e, TRY_LEAVE, TryCatch #2 {JSONException -> 0x006e, blocks: (B:12:0x0027, B:23:0x0046, B:38:0x006a, B:36:0x0066, B:15:0x002f, B:21:0x0042, B:10:0x0023, B:26:0x004e, B:31:0x005b, B:33:0x0062, B:30:0x0058, B:27:0x0052, B:7:0x000b, B:16:0x0033, B:18:0x003e), top: B:47:0x0008, inners: #1, #3, #4 }] */
    /* JADX WARN: Code duplicated, block: B:18:0x003e A[Catch: Exception -> 0x0041, TRY_LEAVE, TryCatch #4 {Exception -> 0x0041, blocks: (B:16:0x0033, B:18:0x003e), top: B:51:0x0033, outer: #2 }] */
    /* JADX WARN: Code duplicated, block: B:33:0x0062 A[Catch: Exception -> 0x0065, TRY_LEAVE, TryCatch #1 {Exception -> 0x0065, blocks: (B:26:0x004e, B:31:0x005b, B:33:0x0062, B:30:0x0058, B:27:0x0052), top: B:45:0x004e, outer: #2, inners: #0 }] */
    /* JADX WARN: Code duplicated, block: B:37:0x0069  */
    /* JADX WARN: Code duplicated, block: B:45:0x004e A[EXC_TOP_SPLITTER, SYNTHETIC] */
    public static JSONObject b(Context context) {
        String string;
        PackageInfo packageInfo;
        String str;
        PackageInfo packageInfo2;
        int i;
        JSONObject jSONObject = new JSONObject();
        String packageName = null;
        try {
            if (context == null) {
                string = null;
                jSONObject.put("n", string);
                if (context == null) {
                    try {
                        packageInfo = context.getPackageManager().getPackageInfo(context.getPackageName(), 0);
                        if (packageInfo != null) {
                            str = packageInfo.versionName;
                        }
                    } catch (Exception e) {
                        e.getMessage();
                    }
                    jSONObject.put(com.kuaishou.weapon.p0.t.c, str);
                    if (context == null) {
                        i = -1;
                        jSONObject.put("c", i);
                    } else {
                        try {
                            PackageManager packageManager = context.getPackageManager();
                            try {
                                packageName = context.getPackageName();
                            } catch (Exception e2) {
                                e2.getMessage();
                            }
                            packageInfo2 = packageManager.getPackageInfo(packageName, 1);
                            if (packageInfo2 != null) {
                                i = packageInfo2.versionCode;
                            } else {
                                i = -1;
                            }
                        } catch (Exception e3) {
                            e3.getMessage();
                        }
                        jSONObject.put("c", i);
                    }
                }
                str = null;
                jSONObject.put(com.kuaishou.weapon.p0.t.c, str);
                if (context == null) {
                    i = -1;
                    jSONObject.put("c", i);
                } else {
                    PackageManager packageManager2 = context.getPackageManager();
                    packageName = context.getPackageName();
                    packageInfo2 = packageManager2.getPackageInfo(packageName, 1);
                    if (packageInfo2 != null) {
                        i = packageInfo2.versionCode;
                    } else {
                        i = -1;
                    }
                    jSONObject.put("c", i);
                }
            } else {
                try {
                    PackageManager packageManager3 = context.getPackageManager();
                    string = packageManager3.getApplicationLabel(packageManager3.getApplicationInfo(context.getPackageName(), 128)).toString();
                } catch (Exception e4) {
                    e4.getMessage();
                    string = null;
                }
                jSONObject.put("n", string);
                if (context == null) {
                    packageInfo = context.getPackageManager().getPackageInfo(context.getPackageName(), 0);
                    if (packageInfo != null) {
                        str = packageInfo.versionName;
                    }
                    jSONObject.put(com.kuaishou.weapon.p0.t.c, str);
                    if (context == null) {
                        i = -1;
                        jSONObject.put("c", i);
                    } else {
                        PackageManager packageManager4 = context.getPackageManager();
                        packageName = context.getPackageName();
                        packageInfo2 = packageManager4.getPackageInfo(packageName, 1);
                        if (packageInfo2 != null) {
                            i = packageInfo2.versionCode;
                        } else {
                            i = -1;
                        }
                        jSONObject.put("c", i);
                    }
                }
                str = null;
                jSONObject.put(com.kuaishou.weapon.p0.t.c, str);
                if (context == null) {
                    i = -1;
                    jSONObject.put("c", i);
                } else {
                    PackageManager packageManager5 = context.getPackageManager();
                    packageName = context.getPackageName();
                    packageInfo2 = packageManager5.getPackageInfo(packageName, 1);
                    if (packageInfo2 != null) {
                        i = packageInfo2.versionCode;
                    } else {
                        i = -1;
                    }
                    jSONObject.put("c", i);
                }
            }
        } catch (JSONException e5) {
            e5.getMessage();
        }
        return jSONObject;
    }

    public static String b(Context context, String str) {
        try {
            JSONObject jSONObject = new JSONObject(str);
            jSONObject.put(PointCategory.APP, b(context));
            boolean z = ap.b;
            String string = jSONObject.toString();
            b = string;
            return string;
        } catch (JSONException e) {
            e.getMessage();
            return str;
        }
    }
}
