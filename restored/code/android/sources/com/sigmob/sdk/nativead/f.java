package com.sigmob.sdk.nativead;

import android.os.Bundle;
import com.czhj.sdk.common.ThreadPool.ThreadPoolFactory;
import com.czhj.volley.toolbox.DownloadItem;
import com.czhj.volley.toolbox.FileDownloadRequest;
import com.czhj.volley.toolbox.FileDownloader;
import com.sigmob.sdk.base.BaseAdActivity;
import com.sigmob.sdk.base.common.AdActivity;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.rtb.MaterialMeta;
import java.io.File;

/* JADX INFO: loaded from: classes4.dex */
public class f extends com.sigmob.sdk.base.common.y {
    private NativeAdBroadcastReceiver c;

    protected f(com.sigmob.sdk.base.common.p listener) {
        super(listener);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a() {
        File adPrivacyTemplateFile = this.b.getAdPrivacyTemplateFile();
        if (adPrivacyTemplateFile == null || adPrivacyTemplateFile.exists()) {
            return;
        }
        DownloadItem downloadItem = new DownloadItem();
        downloadItem.url = this.b.getadPrivacy().privacy_template_url;
        downloadItem.filePath = adPrivacyTemplateFile.getAbsolutePath();
        downloadItem.type = DownloadItem.FileType.OTHER;
        FileDownloader fileDownloaderA = com.sigmob.sdk.base.common.t.a();
        if (fileDownloaderA == null) {
            return;
        }
        fileDownloaderA.add(downloadItem, new FileDownloadRequest.FileDownloadListener() { // from class: com.sigmob.sdk.nativead.f.1
            @Override // com.czhj.volley.toolbox.FileDownloadRequest.FileDownloadListener
            public void downloadProgress(DownloadItem item, long totalSize, long readSize) {
            }

            @Override // com.czhj.volley.toolbox.FileDownloadRequest.FileDownloadListener
            public void onCancel(DownloadItem item) {
            }

            @Override // com.czhj.volley.toolbox.FileDownloadRequest.FileDownloadListener
            public void onErrorResponse(DownloadItem item) {
            }

            @Override // com.czhj.volley.toolbox.FileDownloadRequest.FileDownloadListener
            public void onSuccess(DownloadItem item) {
            }
        });
    }

    private static boolean a(MaterialMeta material) {
        return true;
    }

    @Override // com.sigmob.sdk.base.common.y
    protected void a(com.sigmob.sdk.base.common.p customEventInterstitialListener) {
        ThreadPoolFactory.getFixIOExecutor().submit(new Runnable() { // from class: com.sigmob.sdk.nativead.f$$ExternalSyntheticLambda0
            @Override // java.lang.Runnable
            public final void run() {
                this.f$0.a();
            }
        });
    }

    @Override // com.sigmob.sdk.base.common.y
    public void a(BaseAdUnit baseAdUnit, Bundle option) {
        super.a(baseAdUnit, option);
        if (this.c == null && (this.f3205a instanceof g)) {
            NativeAdBroadcastReceiver nativeAdBroadcastReceiver = new NativeAdBroadcastReceiver((g) this.f3205a, baseAdUnit.getUuid());
            this.c = nativeAdBroadcastReceiver;
            nativeAdBroadcastReceiver.a(nativeAdBroadcastReceiver);
        }
        AdActivity.a(com.sigmob.sdk.b.e(), AdActivity.class, baseAdUnit.getUuid(), option, BaseAdActivity.e);
    }

    @Override // com.sigmob.sdk.base.common.y
    protected boolean a(BaseAdUnit adUnit) {
        if (adUnit.getMaterial() == null) {
            return false;
        }
        return a(adUnit.getMaterial());
    }

    /* JADX WARN: Type inference fix 'apply assigned field type' failed
    java.lang.UnsupportedOperationException: ArgType.getObject(), call class: class jadx.core.dex.instructions.args.ArgType$UnknownArg
    	at jadx.core.dex.instructions.args.ArgType.getObject(ArgType.java:596)
    	at jadx.core.dex.attributes.nodes.ClassTypeVarsAttr.getTypeVarsMapFor(ClassTypeVarsAttr.java:35)
    	at jadx.core.dex.nodes.utils.TypeUtils.replaceClassGenerics(TypeUtils.java:177)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.insertExplicitUseCast(FixTypesVisitor.java:397)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.tryFieldTypeWithNewCasts(FixTypesVisitor.java:359)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.applyFieldType(FixTypesVisitor.java:309)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.visit(FixTypesVisitor.java:94)
     */
    @Override // com.sigmob.sdk.base.common.y
    public void b(BaseAdUnit baseAdUnit) {
        NativeAdBroadcastReceiver nativeAdBroadcastReceiver = this.c;
        if (nativeAdBroadcastReceiver != null) {
            nativeAdBroadcastReceiver.b(nativeAdBroadcastReceiver);
            this.c = null;
        }
        super.b(baseAdUnit);
    }
}
