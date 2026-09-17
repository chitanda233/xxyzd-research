package com.kwad.components.ad.reward.presenter.b;

import android.text.TextUtils;
import android.view.View;
import com.kwad.components.ad.reward.model.AdLiveEndResultData;
import com.kwad.components.ad.reward.n.p;
import com.kwad.components.ad.reward.n.r;
import com.kwad.components.core.video.m;
import com.kwad.components.offline.api.core.adlive.IAdLiveEndRequest;
import com.kwad.sdk.R;
import com.kwad.sdk.components.d;
import com.kwad.sdk.core.network.l;
import com.kwad.sdk.core.network.o;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.BaseResultData;
import com.kwad.sdk.utils.bi;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.reward.presenter.b {
    private IAdLiveEndRequest jk;
    private long kq;
    private p sS;
    private View xZ;
    private final l<com.kwad.components.core.liveEnd.a, AdLiveEndResultData> mNetworking = new l<com.kwad.components.core.liveEnd.a, AdLiveEndResultData>() { // from class: com.kwad.components.ad.reward.presenter.b.b.1
        @Override // com.kwad.sdk.core.network.l
        public final boolean isPostByJson() {
            return false;
        }

        @Override // com.kwad.sdk.core.network.l
        public final /* synthetic */ BaseResultData parseData(String str) {
            return V(str);
        }

        private static AdLiveEndResultData V(String str) {
            AdLiveEndResultData adLiveEndResultData = new AdLiveEndResultData();
            adLiveEndResultData.parseJson(new JSONObject(str));
            return adLiveEndResultData;
        }

        /* JADX INFO: Access modifiers changed from: private */
        @Override // com.kwad.sdk.core.network.a
        /* JADX INFO: renamed from: cO, reason: merged with bridge method [inline-methods] */
        public com.kwad.components.core.liveEnd.a createRequest() {
            return new com.kwad.components.core.liveEnd.a(b.this.jk);
        }
    };
    private final m wH = new m() { // from class: com.kwad.components.ad.reward.presenter.b.b.2
        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayProgress(long j, long j2) {
            super.onMediaPlayProgress(j, j2);
            b.this.kq = j2;
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.h
        public final void onLivePlayEnd() {
            super.onLivePlayEnd();
            b.this.jj();
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.i
        public final void onMediaPlayStart() {
            super.onMediaPlayStart();
            b.this.jk();
        }

        @Override // com.kwad.components.core.video.m, com.kwad.components.core.video.h
        public final void onLivePlayResume() {
            super.onLivePlayResume();
            b.this.jk();
        }
    };

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        com.kwad.components.core.offline.a.c.a aVar;
        super.av();
        if (this.ub.sr.lq()) {
            this.ub.sr.a(this.wH);
            String strBn = com.kwad.sdk.core.response.helper.a.bn(e.eM(this.ub.mAdTemplate));
            if (TextUtils.isEmpty(strBn) || (aVar = (com.kwad.components.core.offline.a.c.a) d.f(com.kwad.components.core.offline.a.c.a.class)) == null) {
                return;
            }
            this.jk = aVar.getAdLiveEndRequest(strBn);
        }
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.mNetworking.cancel();
        if (this.ub.sr.lq()) {
            this.ub.sr.b(this.wH);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void jj() {
        if (this.jk == null) {
            return;
        }
        this.mNetworking.request(new o<com.kwad.components.core.liveEnd.a, AdLiveEndResultData>() { // from class: com.kwad.components.ad.reward.presenter.b.b.3
            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.core.network.o, com.kwad.sdk.core.network.g
            /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
            public void onStartRequest(com.kwad.components.core.liveEnd.a aVar) {
                super.onStartRequest(aVar);
            }

            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.core.network.o, com.kwad.sdk.core.network.g
            /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
            public void onSuccess(com.kwad.components.core.liveEnd.a aVar, final AdLiveEndResultData adLiveEndResultData) {
                super.onSuccess(aVar, adLiveEndResultData);
                if (adLiveEndResultData.mQLivePushEndInfo == null) {
                    return;
                }
                b.this.ub.mRootContainer.post(new bi() { // from class: com.kwad.components.ad.reward.presenter.b.b.3.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        if (b.this.sS == null) {
                            b.this.sS = new p(b.this.ub);
                        }
                        b.this.sS.j(b.this.ub.mRootContainer);
                        b.this.sS.b(r.ad(b.this.ub.mAdTemplate));
                        b.this.sS.a(b.this.ub, adLiveEndResultData.mQLivePushEndInfo, b.this.kq);
                        b.this.ub.sS = b.this.sS;
                        if (b.this.ub.mContext.getResources().getConfiguration().orientation == 2) {
                            b.this.xZ = b.this.findViewById(R.id.ksad_live_end_page_layout_root_landscape);
                        } else {
                            b.this.xZ = b.this.findViewById(R.id.ksad_live_end_page_layout_root);
                        }
                        b.this.xZ.setVisibility(0);
                        b.this.iS();
                    }
                });
            }

            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.core.network.o, com.kwad.sdk.core.network.g
            /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
            public void onError(com.kwad.components.core.liveEnd.a aVar, int i, String str) {
                super.onError(aVar, i, str);
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void jk() {
        View view = this.xZ;
        if (view != null) {
            view.setVisibility(8);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void iS() {
        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
        com.kwad.sdk.core.adlog.a.C0502a c0502a = new com.kwad.sdk.core.adlog.a.C0502a();
        bVar.eb(24);
        bVar.b(c0502a);
        com.kwad.components.ad.reward.j.b.a(true, this.ub.mAdTemplate, null, bVar);
    }
}
