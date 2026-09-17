package com.sigmob.sdk.base.views;

import android.text.TextUtils;
import android.webkit.JavascriptInterface;
import com.sigmob.sdk.base.models.BaseAdUnit;

/* JADX INFO: loaded from: classes3.dex */
public class af {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final BaseAdUnit f3284a;
    private final a b;

    public interface a {
        void a();

        void b();
    }

    af(BaseAdUnit adUnit, a listener) {
        this.f3284a = adUnit;
        this.b = listener;
    }

    @JavascriptInterface
    public boolean canInstall(String apkName) {
        if (this.f3284a == null) {
            return false;
        }
        if (TextUtils.isEmpty(apkName)) {
            apkName = TextUtils.isEmpty(this.f3284a.getApkMd5()) ? "" : this.f3284a.getApkMd5() + ".apk";
            if (!TextUtils.isEmpty(this.f3284a.getApkName())) {
                apkName = this.f3284a.getApkName();
            }
        }
        return this.f3284a.canInstall(apkName);
    }

    @JavascriptInterface
    public boolean canOpen(String packageName) {
        BaseAdUnit baseAdUnit;
        return (!TextUtils.isEmpty(packageName) || (baseAdUnit = this.f3284a) == null) ? com.sigmob.sdk.base.o.a().b(packageName).booleanValue() : baseAdUnit.canOpen();
    }

    @JavascriptInterface
    public int getInteractionType() {
        BaseAdUnit baseAdUnit = this.f3284a;
        if (baseAdUnit == null) {
            return 0;
        }
        return baseAdUnit.getInteractionType();
    }

    @JavascriptInterface
    public int getSubInteractionType() {
        BaseAdUnit baseAdUnit = this.f3284a;
        if (baseAdUnit == null) {
            return 0;
        }
        return baseAdUnit.getsubInteractionType();
    }

    @JavascriptInterface
    public void hideSystemUI() {
        if (com.sigmob.sdk.base.utils.v.b(this.b)) {
            this.b.b();
        }
    }

    @JavascriptInterface
    public boolean isOpenListReport() {
        com.sigmob.sdk.base.o oVarA = com.sigmob.sdk.base.o.a();
        return (oVarA.S().isEmpty() || com.sigmob.sdk.base.services.b.a() || !oVarA.L().booleanValue()) ? false : true;
    }

    @JavascriptInterface
    public void onOpenListReport() {
        com.sigmob.sdk.base.services.b.c();
    }

    @JavascriptInterface
    public void showSystemUI() {
        if (com.sigmob.sdk.base.utils.v.b(this.b)) {
            this.b.a();
        }
    }
}
