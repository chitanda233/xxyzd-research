package com.kwad.components.core.innerEc.live.like;

import com.kwad.components.core.innerEc.f;
import com.kwad.components.core.innerEc.live.i.e;
import com.kwad.sdk.core.network.l;
import com.kwad.sdk.core.network.o;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.BaseResultData;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Set;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private final AdTemplate TY;
    private final Set<a> Xp = new HashSet();

    public interface a {
        void a(LikeResponse likeResponse);

        void sL();
    }

    public b(AdTemplate adTemplate) {
        this.TY = adTemplate;
    }

    public final void a(a aVar) {
        this.Xp.add(aVar);
    }

    public final void b(a aVar) {
        this.Xp.remove(aVar);
    }

    public final void aP(final int i) {
        new l<com.kwad.components.core.innerEc.live.like.a, LikeResponse>() { // from class: com.kwad.components.core.innerEc.live.like.b.1
            @Override // com.kwad.sdk.core.network.l
            public final /* synthetic */ BaseResultData parseData(String str) {
                return aL(str);
            }

            private static LikeResponse aL(String str) {
                JSONObject jSONObject = new JSONObject(str);
                LikeResponse likeResponse = new LikeResponse();
                likeResponse.parseJson(jSONObject);
                return likeResponse;
            }

            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.core.network.a
            /* JADX INFO: renamed from: sU, reason: merged with bridge method [inline-methods] */
            public com.kwad.components.core.innerEc.live.like.a createRequest() {
                return new com.kwad.components.core.innerEc.live.like.a(com.kwad.components.core.innerEc.live.base.b.rH().aB(e.aI(b.this.TY)).aL(i).F(1L).aA(e.aJ(b.this.TY)).aC(e.getKwaiUserId()), f.ri());
            }
        }.request(new o<com.kwad.components.core.innerEc.live.like.a, LikeResponse>() { // from class: com.kwad.components.core.innerEc.live.like.b.2
            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.core.network.o, com.kwad.sdk.core.network.g
            /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
            public void onSuccess(com.kwad.components.core.innerEc.live.like.a aVar, final LikeResponse likeResponse) {
                super.onSuccess(aVar, likeResponse);
                by.postOnUiThread(new bi() { // from class: com.kwad.components.core.innerEc.live.like.b.2.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        b.this.a(likeResponse);
                    }
                });
            }

            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.core.network.o, com.kwad.sdk.core.network.g
            /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
            public void onError(com.kwad.components.core.innerEc.live.like.a aVar, int i2, String str) {
                super.onError(aVar, i2, str);
                by.postOnUiThread(new bi() { // from class: com.kwad.components.core.innerEc.live.like.b.2.2
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        b.this.k(null);
                    }
                });
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(LikeResponse likeResponse) {
        try {
            b(likeResponse);
        } catch (Throwable th) {
            ServiceProvider.reportSdkCaughtException(th);
        }
    }

    private void b(LikeResponse likeResponse) {
        Iterator<a> it = this.Xp.iterator();
        while (it.hasNext()) {
            it.next().a(likeResponse);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void k(Throwable th) {
        try {
            Iterator<a> it = this.Xp.iterator();
            while (it.hasNext()) {
                it.next().sL();
            }
        } catch (Throwable th2) {
            ServiceProvider.reportSdkCaughtException(th2);
        }
    }
}
