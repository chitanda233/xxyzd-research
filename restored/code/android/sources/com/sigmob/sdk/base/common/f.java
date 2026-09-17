package com.sigmob.sdk.base.common;

import android.content.ComponentName;
import android.content.Context;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.content.pm.ProviderInfo;
import android.content.res.XmlResourceParser;
import android.os.Bundle;
import android.text.TextUtils;
import com.czhj.sdk.common.mta.PointEntitySuper;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.models.AppInfo;
import com.sigmob.sdk.base.models.rtb.Ad;
import com.sigmob.sdk.base.models.rtb.MaterialMeta;
import com.sigmob.windad.WindAdError;

/* JADX INFO: loaded from: classes3.dex */
public class f {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static Boolean f3168a;

    public static String[] a() {
        Context contextE = com.sigmob.sdk.b.e();
        if (contextE == null) {
            return null;
        }
        try {
            return contextE.getPackageManager().getPackageInfo(contextE.getPackageName(), 4096).requestedPermissions;
        } catch (Throwable unused) {
            return null;
        }
    }

    public static WindAdError b() {
        Context contextE = com.sigmob.sdk.b.e();
        try {
            SigmobLog.d("checkActivity: " + AdActivity.class.getName());
            contextE.getPackageManager().getActivityInfo(new ComponentName(contextE, (Class<?>) AdActivity.class), 128);
        } catch (PackageManager.NameNotFoundException e) {
            SigmobLog.e("checkActivity: " + e.getMessage());
            return WindAdError.ERROR_LOAD_FILTER_FOR_ACTIVITY_ERROR;
        } catch (Throwable th) {
            th.printStackTrace();
        }
        try {
            if (!Ad.class.getName().endsWith("base.models.rtb.Ad")) {
                SigmobLog.e("checkProguard Ad: " + Ad.class.getName());
                return WindAdError.ERROR_LOAD_FILTER_FOR_PROGUARD_ERROR;
            }
            if (!MaterialMeta.class.getName().endsWith("base.models.rtb.MaterialMeta")) {
                SigmobLog.e("checkProguard Strategy: " + MaterialMeta.class.getName());
                return WindAdError.ERROR_LOAD_FILTER_FOR_PROGUARD_ERROR;
            }
            if (!AppInfo.class.getName().endsWith("base.models.AppInfo")) {
                SigmobLog.e("checkProguard AppInfo: " + AppInfo.class.getName());
                return WindAdError.ERROR_LOAD_FILTER_FOR_PROGUARD_ERROR;
            }
            if (PointEntitySuper.class.getName().endsWith("common.mta.PointEntitySuper")) {
                return null;
            }
            SigmobLog.e("checkProguard PointCategory: " + PointEntitySuper.class.getName());
            return WindAdError.ERROR_LOAD_FILTER_FOR_PROGUARD_ERROR;
        } catch (Throwable th2) {
            SigmobLog.e("checkProguard: " + th2.getMessage());
            return null;
        }
    }

    /* JADX WARN: Code duplicated, block: B:23:0x0053 A[Catch: all -> 0x0148, TRY_LEAVE, TryCatch #2 {, blocks: (B:4:0x0003, B:6:0x0007, B:21:0x004d, B:23:0x0053, B:26:0x005b, B:28:0x0060, B:30:0x0072, B:32:0x0078, B:35:0x007f, B:37:0x0098, B:39:0x00ad, B:46:0x00d5, B:49:0x00dd, B:64:0x0140, B:43:0x00b8, B:20:0x0033, B:11:0x0010, B:13:0x0020, B:15:0x0024), top: B:75:0x0003, inners: #1, #3 }] */
    /* JADX WARN: Code duplicated, block: B:26:0x005b A[Catch: all -> 0x0148, TRY_ENTER, TRY_LEAVE, TryCatch #2 {, blocks: (B:4:0x0003, B:6:0x0007, B:21:0x004d, B:23:0x0053, B:26:0x005b, B:28:0x0060, B:30:0x0072, B:32:0x0078, B:35:0x007f, B:37:0x0098, B:39:0x00ad, B:46:0x00d5, B:49:0x00dd, B:64:0x0140, B:43:0x00b8, B:20:0x0033, B:11:0x0010, B:13:0x0020, B:15:0x0024), top: B:75:0x0003, inners: #1, #3 }] */
    /* JADX WARN: Code duplicated, block: B:30:0x0072 A[Catch: Exception -> 0x00b7, all -> 0x0148, TryCatch #3 {Exception -> 0x00b7, blocks: (B:28:0x0060, B:30:0x0072, B:32:0x0078, B:35:0x007f, B:37:0x0098, B:39:0x00ad), top: B:76:0x0060, outer: #2 }] */
    /* JADX WARN: Code duplicated, block: B:32:0x0078 A[Catch: Exception -> 0x00b7, all -> 0x0148, TryCatch #3 {Exception -> 0x00b7, blocks: (B:28:0x0060, B:30:0x0072, B:32:0x0078, B:35:0x007f, B:37:0x0098, B:39:0x00ad), top: B:76:0x0060, outer: #2 }] */
    /* JADX WARN: Code duplicated, block: B:39:0x00ad A[Catch: Exception -> 0x00b7, all -> 0x0148, EDGE_INSN: B:39:0x00ad->B:45:0x00d3 BREAK  A[LOOP:1: B:31:0x0076->B:41:0x00b4], TRY_LEAVE, TryCatch #3 {Exception -> 0x00b7, blocks: (B:28:0x0060, B:30:0x0072, B:32:0x0078, B:35:0x007f, B:37:0x0098, B:39:0x00ad), top: B:76:0x0060, outer: #2 }] */
    /* JADX WARN: Code duplicated, block: B:44:0x00d2 A[EDGE_INSN: B:44:0x00d2->B:45:0x00d3 BREAK  A[LOOP:1: B:31:0x0076->B:41:0x00b4]] */
    /* JADX WARN: Code duplicated, block: B:46:0x00d5 A[Catch: all -> 0x0148, TRY_LEAVE, TryCatch #2 {, blocks: (B:4:0x0003, B:6:0x0007, B:21:0x004d, B:23:0x0053, B:26:0x005b, B:28:0x0060, B:30:0x0072, B:32:0x0078, B:35:0x007f, B:37:0x0098, B:39:0x00ad, B:46:0x00d5, B:49:0x00dd, B:64:0x0140, B:43:0x00b8, B:20:0x0033, B:11:0x0010, B:13:0x0020, B:15:0x0024), top: B:75:0x0003, inners: #1, #3 }] */
    /* JADX WARN: Code duplicated, block: B:49:0x00dd A[Catch: all -> 0x0148, TRY_ENTER, TRY_LEAVE, TryCatch #2 {, blocks: (B:4:0x0003, B:6:0x0007, B:21:0x004d, B:23:0x0053, B:26:0x005b, B:28:0x0060, B:30:0x0072, B:32:0x0078, B:35:0x007f, B:37:0x0098, B:39:0x00ad, B:46:0x00d5, B:49:0x00dd, B:64:0x0140, B:43:0x00b8, B:20:0x0033, B:11:0x0010, B:13:0x0020, B:15:0x0024), top: B:75:0x0003, inners: #1, #3 }] */
    /* JADX WARN: Code duplicated, block: B:53:0x00ec  */
    /* JADX WARN: Code duplicated, block: B:82:0x00d2 A[SYNTHETIC] */
    public static synchronized boolean c() {
        Context contextE;
        int i;
        XmlResourceParser xml;
        int eventType;
        PackageInfo packageInfo;
        ProviderInfo[] providerInfoArr;
        int length;
        int i2;
        ProviderInfo providerInfo;
        String str;
        Bundle bundle;
        Boolean bool = f3168a;
        if (bool != null) {
            return bool.booleanValue();
        }
        String str2 = "";
        try {
            f3168a = false;
            String[] strArrA = a();
            if (!com.sigmob.sdk.base.utils.f.b(strArrA)) {
                if (TextUtils.isEmpty(str2)) {
                    return f3168a.booleanValue();
                }
                contextE = com.sigmob.sdk.b.e();
                String packageName = contextE.getPackageName();
                packageInfo = contextE.getPackageManager().getPackageInfo(packageName, 8);
                if (packageInfo.providers != null) {
                    i = -1;
                    break;
                }
                providerInfoArr = packageInfo.providers;
                length = providerInfoArr.length;
                i2 = 0;
                while (true) {
                    if (i2 >= length) {
                        providerInfo = providerInfoArr[i2];
                        str = providerInfo.authority;
                        if (str != null) {
                            bundle = contextE.getPackageManager().getProviderInfo(new ComponentName(contextE, providerInfo.name), 128).metaData;
                            if (bundle != null) {
                                i = bundle.getInt("android.support.FILE_PROVIDER_PATHS");
                                break;
                            }
                        }
                        i2++;
                    }
                    i = -1;
                    break;
                }
                if (i == -1) {
                    return f3168a.booleanValue();
                }
                xml = contextE.getResources().getXml(i);
                for (eventType = xml.getEventType(); eventType != 1; eventType = xml.next()) {
                    if (eventType != 2) {
                    }
                }
                xml.close();
                return f3168a.booleanValue();
            }
            for (String str3 : strArrA) {
                if (str3.equals("android.permission.REQUEST_INSTALL_PACKAGES")) {
                    str2 = str3;
                }
            }
            if (TextUtils.isEmpty(str2)) {
                return f3168a.booleanValue();
            }
            contextE = com.sigmob.sdk.b.e();
            try {
                String packageName2 = contextE.getPackageName();
                packageInfo = contextE.getPackageManager().getPackageInfo(packageName2, 8);
                if (packageInfo.providers != null) {
                    i = -1;
                    break;
                }
                providerInfoArr = packageInfo.providers;
                length = providerInfoArr.length;
                i2 = 0;
                while (true) {
                    if (i2 >= length) {
                        providerInfo = providerInfoArr[i2];
                        str = providerInfo.authority;
                        if (str != null && str.equals(packageName2 + ".sigprovider")) {
                            bundle = contextE.getPackageManager().getProviderInfo(new ComponentName(contextE, providerInfo.name), 128).metaData;
                            if (bundle != null) {
                                i = bundle.getInt("android.support.FILE_PROVIDER_PATHS");
                                break;
                            }
                        }
                        i2++;
                    }
                    i = -1;
                    break;
                }
            } catch (Exception e) {
                SigmobLog.e("check targetAuthority:" + e.getMessage());
            }
            if (i == -1) {
                return f3168a.booleanValue();
            }
            xml = contextE.getResources().getXml(i);
            try {
                while (eventType != 1) {
                    if (eventType != 2 && xml.getName().equals("external-cache-path") && xml.getAttributeCount() >= 2) {
                        String attributeValue = xml.getAttributeValue(0);
                        String attributeValue2 = xml.getAttributeValue(1);
                        if (attributeValue.equals("SigMob_root")) {
                            f3168a = true;
                            SigmobLog.d("check name: " + attributeValue + " path :" + attributeValue2);
                            break;
                        }
                    }
                }
                xml.close();
            } catch (Throwable unused) {
            }
            return f3168a.booleanValue();
        } catch (Throwable th) {
            SigmobLog.e("checkPermission: error = " + th.getMessage());
        }
        throw th;
    }

    public static boolean d() {
        String[] strArrA = a();
        if (strArrA == null) {
            return false;
        }
        for (String str : strArrA) {
            if (str.equals("android.permission.QUERY_ALL_PACKAGES")) {
                return true;
            }
        }
        return false;
    }
}
