package com.kwad.sdk.api.loader;

import android.content.Context;
import android.content.res.Resources;
import android.os.Build;
import android.text.TextUtils;
import com.kwad.sdk.api.core.IKsAdSDK;
import java.io.File;

/* JADX INFO: loaded from: classes3.dex */
final class m {
    private ClassLoader aIA;
    private IKsAdSDK aIB;
    private final String aIw;
    private final String aIx;
    private final String aIy;
    private Resources aIz;

    public final String toString() {
        return "ExternalPackage{mApk='" + this.aIw + "', mDexDir='" + this.aIx + "', mNativeLibDir='" + this.aIy + "', mResource=" + this.aIz + ", mClassLoader=" + this.aIA + ", mKsSdk=" + this.aIB + '}';
    }

    final Resources HQ() {
        return this.aIz;
    }

    final ClassLoader getClassLoader() {
        return this.aIA;
    }

    final IKsAdSDK HR() {
        return this.aIB;
    }

    private m(String str, String str2, String str3) {
        this.aIw = str;
        this.aIx = str2;
        this.aIy = str3;
    }

    static synchronized m a(Context context, ClassLoader classLoader, String str) {
        try {
        } catch (Throwable th) {
            com.kwad.sdk.api.c.t(th);
            return null;
        }
        return b(context, classLoader, j.y(context, str), j.z(context, str), j.A(context, str));
    }

    static m b(Context context, ClassLoader classLoader, String str, String str2, String str3) {
        if (TextUtils.isEmpty(str)) {
            throw new RuntimeException("mApk is null");
        }
        File file = new File(str);
        if (!file.exists() || !file.isFile()) {
            throw new RuntimeException("mApk not a file");
        }
        try {
            if (Build.VERSION.SDK_INT >= 34 && context != null && context.getApplicationInfo().targetSdkVersion >= 34) {
                file.setReadOnly();
            }
        } catch (Throwable unused) {
        }
        m mVar = new m(str, str2, str3);
        mVar.a(context, classLoader);
        return mVar;
    }

    private void a(Context context, ClassLoader classLoader) {
        HS();
        Resources resourcesA = w.a(context, context.getResources(), this.aIw);
        ClassLoader classLoaderA = g.a(context, classLoader, this.aIw, this.aIx, this.aIy);
        IKsAdSDK iKsAdSDKA = Loader.a(classLoaderA);
        this.aIz = resourcesA;
        this.aIA = classLoaderA;
        this.aIB = iKsAdSDKA;
        if (!(iKsAdSDKA.getClass().getClassLoader() instanceof g.a)) {
            throw new RuntimeException("classLoader is not expect dynamic classloader:");
        }
        int sDKType = iKsAdSDKA.getSDKType();
        if (sDKType != 1) {
            throw new RuntimeException("sdkType error apiType: 1 , sdkType:" + sDKType);
        }
    }

    private void HS() {
        if (TextUtils.isEmpty(this.aIw)) {
            throw new RuntimeException("mApk is null");
        }
        File file = new File(this.aIw);
        if (!file.isFile() || !file.exists()) {
            throw new RuntimeException("mApk not a file");
        }
    }
}
