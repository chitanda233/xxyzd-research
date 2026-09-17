package com.gorilla.base.service;

import android.app.Application;
import android.content.pm.ApplicationInfo;
import android.util.Log;
import com.gorilla.base.log.LogFactory;

/* JADX INFO: loaded from: classes3.dex */
public class MetaDataService {
    private static final String KEY_ENABLE_LOG = "com.gorilla.sdk.enable.log";
    private static Application app;

    public static void init(Application application) {
        app = application;
        boolean metaData = getMetaData(KEY_ENABLE_LOG, true);
        if (!metaData) {
            Log.d("[Gorilla]", "[MetaDataService] Disable log");
        }
        LogFactory.enableLog(metaData);
    }

    public static String getMetaData(String str, String str2) {
        try {
            Application application = app;
            if (application == null) {
                return str2;
            }
            ApplicationInfo applicationInfo = application.getPackageManager().getApplicationInfo(app.getPackageName(), 128);
            if (applicationInfo.metaData != null) {
                return applicationInfo.metaData.getString(str, str2);
            }
        } catch (Exception e) {
            Log.e("MetaDataService", "getMetaData error: " + e.getMessage() + ", key: " + str);
        }
        return str2;
    }

    public static int getMetaData(String str, int i) {
        try {
            Application application = app;
            if (application == null) {
                return i;
            }
            ApplicationInfo applicationInfo = application.getPackageManager().getApplicationInfo(app.getPackageName(), 128);
            if (applicationInfo.metaData != null) {
                return applicationInfo.metaData.getInt(str, i);
            }
        } catch (Exception e) {
            Log.e("MetaDataService", "getMetaData error: " + e.getMessage() + ", key: " + str);
        }
        return i;
    }

    public static boolean getMetaData(String str, boolean z) {
        try {
            Application application = app;
            if (application == null) {
                return z;
            }
            ApplicationInfo applicationInfo = application.getPackageManager().getApplicationInfo(app.getPackageName(), 128);
            if (applicationInfo.metaData != null) {
                return applicationInfo.metaData.getBoolean(str, z);
            }
        } catch (Exception e) {
            Log.e("MetaDataService", "getMetaData error: " + e.getMessage() + ", key: " + str);
        }
        return z;
    }
}
