package com.gorilla.base;

import android.app.ActivityManager;
import android.app.Application;
import android.content.ContentProvider;
import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.net.Uri;
import android.os.Build;
import android.os.Process;
import android.util.Log;
import com.byazt.hv.TTDownloadField;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class InitializeProvider extends ContentProvider {
    @Override // android.content.ContentProvider
    public int delete(Uri uri, String str, String[] strArr) {
        return 0;
    }

    @Override // android.content.ContentProvider
    public String getType(Uri uri) {
        return null;
    }

    @Override // android.content.ContentProvider
    public Uri insert(Uri uri, ContentValues contentValues) {
        return null;
    }

    @Override // android.content.ContentProvider
    public Cursor query(Uri uri, String[] strArr, String str, String[] strArr2, String str2) {
        return null;
    }

    @Override // android.content.ContentProvider
    public int update(Uri uri, ContentValues contentValues, String str, String[] strArr) {
        return 0;
    }

    @Override // android.content.ContentProvider
    public boolean onCreate() {
        Context context = getContext();
        if (context == null) {
            return false;
        }
        if (!isMainProcess(context.getApplicationContext())) {
            Log.d("InitializeProvider", "Skip init in non-main process");
            return true;
        }
        Api.onApplicationCreate(context);
        return true;
    }

    private boolean isMainProcess(Context context) {
        if (context == null) {
            return true;
        }
        String packageName = context.getPackageName();
        if (Build.VERSION.SDK_INT >= 28) {
            return packageName != null && packageName.equals(Application.getProcessName());
        }
        ActivityManager activityManager = (ActivityManager) context.getSystemService(TTDownloadField.TT_ACTIVITY);
        if (activityManager == null) {
            return true;
        }
        int iMyPid = Process.myPid();
        List<ActivityManager.RunningAppProcessInfo> runningAppProcesses = activityManager.getRunningAppProcesses();
        if (runningAppProcesses == null) {
            return true;
        }
        for (ActivityManager.RunningAppProcessInfo runningAppProcessInfo : runningAppProcesses) {
            if (runningAppProcessInfo != null && iMyPid == runningAppProcessInfo.pid) {
                return packageName != null && packageName.equals(runningAppProcessInfo.processName);
            }
        }
        return true;
    }
}
