package com.kwad.components.core.widget;

import android.content.Context;
import android.util.AttributeSet;
import com.kwad.sdk.api.KsAppDownloadListener;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public class KsConvertButton extends KSCornerButton implements KsAppDownloadListener {
    private AdTemplate mAdTemplate;
    private com.kwad.components.core.e.d.d mApkDownloadHelper;

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public void onDownloadFinished() {
    }

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public void onDownloadStarted() {
    }

    public KsConvertButton(Context context) {
        super(context);
    }

    public KsConvertButton(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
    }

    public KsConvertButton(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
    }

    public KsConvertButton(Context context, AttributeSet attributeSet, int i, int i2) {
        super(context, attributeSet, i, i2);
    }

    public final void a(com.kwad.components.core.e.d.d dVar, AdTemplate adTemplate) {
        this.mApkDownloadHelper = dVar;
        this.mAdTemplate = adTemplate;
        if (dVar != null) {
            dVar.b(this);
        }
        bQ(getAdActionDesc());
    }

    private String getAdActionDesc() {
        AdTemplate adTemplate = this.mAdTemplate;
        if (adTemplate != null) {
            return com.kwad.sdk.core.response.helper.a.aK(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
        }
        return null;
    }

    private void bQ(String str) {
        if (str != null) {
            setText(str);
        }
    }

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public void onIdle() {
        bQ(getAdActionDesc());
    }

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public void onProgressUpdate(int i) {
        bQ("下载中..." + i + "%");
    }

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public void onInstalled() {
        AdTemplate adTemplate = this.mAdTemplate;
        bQ(adTemplate != null ? com.kwad.sdk.core.response.helper.a.af(com.kwad.sdk.core.response.helper.e.eM(adTemplate)) : "立即打开");
    }

    @Override // com.kwad.sdk.api.KsAppDownloadListener
    public void onDownloadFailed() {
        AdTemplate adTemplate = this.mAdTemplate;
        bQ(adTemplate != null ? com.kwad.sdk.core.response.helper.a.aK(com.kwad.sdk.core.response.helper.e.eM(adTemplate)) : "立即下载");
    }
}
