package com.kwad.components.core.liveEnd;

import android.text.TextUtils;
import com.kwad.components.offline.api.core.adlive.IAdLiveEndRequest;
import com.kwad.sdk.core.network.b;
import com.kwad.sdk.utils.bb;
import java.util.Map;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends b {
    private IAdLiveEndRequest jk;

    @Override // com.kwad.sdk.core.network.b
    public final void buildBaseBody() {
    }

    @Override // com.kwad.sdk.core.network.b
    public final void buildBaseHeader() {
    }

    public a(IAdLiveEndRequest iAdLiveEndRequest) {
        this.jk = iAdLiveEndRequest;
    }

    @Override // com.kwad.sdk.core.network.b, com.kwad.sdk.core.network.f
    public final String getUrl() {
        return bb.appendUrl(this.jk.getUrl(), this.jk.getUrlParam());
    }

    @Override // com.kwad.sdk.core.network.b, com.kwad.sdk.core.network.f
    public final Map<String, String> getHeader() {
        IAdLiveEndRequest iAdLiveEndRequest = this.jk;
        if (iAdLiveEndRequest == null || iAdLiveEndRequest.getHeader() == null || this.jk.getHeader().size() <= 0) {
            return super.getHeader();
        }
        for (String str : this.jk.getHeader().keySet()) {
            if (!TextUtils.isEmpty(this.jk.getHeader().get(str))) {
                addHeader(str, this.jk.getHeader().get(str));
            }
        }
        return super.getHeader();
    }

    @Override // com.kwad.sdk.core.network.b, com.kwad.sdk.core.network.f
    public final Map<String, String> getBodyMap() {
        return this.jk.getBodyMap();
    }
}
