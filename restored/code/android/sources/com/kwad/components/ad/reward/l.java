package com.kwad.components.ad.reward;

import android.content.Context;
import com.kwad.components.core.page.DownloadLandPageActivity;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class l {
    public static void j(g gVar) {
        AdTemplate adTemplate = gVar.mAdTemplate;
        Context context = gVar.mContext;
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        if ((com.kwad.sdk.core.response.helper.a.bQ(adInfoEM) && gVar.ss != null && gVar.ss.vL()) || com.kwad.components.ad.reward.a.b.l(adInfoEM) || adTemplate.mXiaomiAppStoreDetailViewOpen || !com.kwad.sdk.core.response.helper.a.aL(adInfoEM) || !com.kwad.sdk.core.response.helper.a.az(adInfoEM) || adTemplate.hasEnterAdWebViewLandPageActivity) {
            return;
        }
        gVar.mAdTemplate.hasEnterAdWebViewLandPageActivity = true;
        DownloadLandPageActivity.launch(context, adTemplate, true);
    }
}
