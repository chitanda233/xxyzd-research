package com.tencent.turingfd.sdk.ams.ad;

import android.content.Context;
import android.content.pm.PackageInfo;
import android.content.pm.PackageManager;
import android.os.Build;
import com.byazt.quv.AbsServerManager;
import java.io.InputStream;
import java.util.concurrent.atomic.AtomicReference;
import java.util.zip.ZipFile;

/* JADX INFO: loaded from: classes4.dex */
public abstract class CanisMajor {
    public static String a(Context context, String str) {
        String nodeValue;
        ZipFile zipFile;
        PackageInfo packageArchiveInfo;
        int i = 0;
        InputStream inputStream = null;
        try {
            PackageManager packageManager = context.getApplicationContext().getPackageManager();
            nodeValue = (packageManager == null || (packageArchiveInfo = packageManager.getPackageArchiveInfo(str, 0)) == null) ? null : packageArchiveInfo.packageName;
        } catch (Throwable unused) {
        }
        if (nodeValue != null) {
            return nodeValue;
        }
        try {
            try {
                zipFile = new ZipFile(str);
                try {
                    InputStream inputStream2 = zipFile.getInputStream(zipFile.getEntry("AndroidManifest.xml"));
                    try {
                        nodeValue = new Ccontinue().a(inputStream2).getChildNodes().item(0).getAttributes().getNamedItem(AbsServerManager.PACKAGE_QUERY_BINDER).getNodeValue();
                        GalacticCore.a(inputStream2);
                        AtomicReference atomicReference = Cprotected.f3954a;
                        try {
                            i = Integer.parseInt(Build.VERSION.SDK);
                        } catch (Throwable unused2) {
                        }
                        if (i >= 19) {
                            GalacticCore.a(zipFile);
                        } else {
                            zipFile.close();
                        }
                    } catch (Throwable unused3) {
                        inputStream = inputStream2;
                        GalacticCore.a(inputStream);
                        AtomicReference atomicReference2 = Cprotected.f3954a;
                        try {
                            i = Integer.parseInt(Build.VERSION.SDK);
                        } catch (Throwable unused4) {
                        }
                        if (i >= 19) {
                            GalacticCore.a(zipFile);
                        } else {
                            zipFile.close();
                        }
                    }
                } catch (Throwable unused5) {
                }
            } catch (Throwable unused6) {
                zipFile = null;
            }
        } catch (Throwable unused7) {
        }
        return nodeValue;
    }
}
