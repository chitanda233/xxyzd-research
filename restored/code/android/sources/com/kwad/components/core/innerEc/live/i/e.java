package com.kwad.components.core.innerEc.live.i;

import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.LiveInfo;

/* JADX INFO: loaded from: classes3.dex */
public final class e {
    public static String e(AdTemplate adTemplate, int i) {
        LiveInfo liveInfo = adTemplate.liveInfo;
        String str = liveInfo.liveStreamId + "_" + i;
        liveInfo.pageDataKey = str;
        liveInfo.livePageType = 0;
        return str;
    }

    public static String aI(AdTemplate adTemplate) {
        return adTemplate.liveInfo.liveStreamId;
    }

    public static void e(AdTemplate adTemplate, String str) {
        adTemplate.liveInfo.liveStreamId = str;
    }

    public static String getKwaiUserId() {
        return new StringBuilder().append(com.kwad.components.core.innerEc.e.re().getUserId()).toString();
    }

    public static String aJ(AdTemplate adTemplate) {
        return String.valueOf(adTemplate.liveInfo.authorId);
    }
}
