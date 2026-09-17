package com.kwad.components.core.innerEc.live.comment.history;

import com.kwad.components.core.innerEc.f;
import com.kwad.components.core.innerEc.live.i.e;
import com.kwad.sdk.core.d.c;
import com.kwad.sdk.core.network.l;
import com.kwad.sdk.core.network.o;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.response.model.BaseResultData;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.by;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Set;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b {
    private final Set<a> TX = new HashSet();
    private final AdTemplate TY;

    public interface a {
        void c(HistoryCommentsResponse historyCommentsResponse);

        void rO();
    }

    public b(AdTemplate adTemplate) {
        this.TY = adTemplate;
    }

    public final void a(a aVar) {
        this.TX.add(aVar);
    }

    public final void b(a aVar) {
        this.TX.remove(aVar);
    }

    public final void rM() {
        new l<com.kwad.components.core.innerEc.live.comment.history.a, HistoryCommentsResponse>() { // from class: com.kwad.components.core.innerEc.live.comment.history.b.1
            @Override // com.kwad.sdk.core.network.l
            public final /* synthetic */ BaseResultData parseData(String str) {
                return aF(str);
            }

            private static HistoryCommentsResponse aF(String str) {
                JSONObject jSONObject = new JSONObject(str);
                HistoryCommentsResponse historyCommentsResponse = new HistoryCommentsResponse();
                historyCommentsResponse.parseJson(jSONObject);
                return historyCommentsResponse;
            }

            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.core.network.a
            /* JADX INFO: renamed from: rN, reason: merged with bridge method [inline-methods] */
            public com.kwad.components.core.innerEc.live.comment.history.a createRequest() {
                return new com.kwad.components.core.innerEc.live.comment.history.a(com.kwad.components.core.innerEc.live.base.b.rH().aB(e.aI(b.this.TY)).aA(e.aJ(b.this.TY)).aC(e.getKwaiUserId()), f.ri());
            }
        }.request(new o<com.kwad.components.core.innerEc.live.comment.history.a, HistoryCommentsResponse>() { // from class: com.kwad.components.core.innerEc.live.comment.history.b.2
            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.core.network.o, com.kwad.sdk.core.network.g
            /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
            public void onSuccess(com.kwad.components.core.innerEc.live.comment.history.a aVar, final HistoryCommentsResponse historyCommentsResponse) {
                super.onSuccess(aVar, historyCommentsResponse);
                c.d("HistoryCommentsService", "fetchHistoryComments success");
                by.postOnUiThread(new bi() { // from class: com.kwad.components.core.innerEc.live.comment.history.b.2.1
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        b.this.a(historyCommentsResponse);
                    }
                });
            }

            /* JADX INFO: Access modifiers changed from: private */
            @Override // com.kwad.sdk.core.network.o, com.kwad.sdk.core.network.g
            /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
            public void onError(com.kwad.components.core.innerEc.live.comment.history.a aVar, int i, final String str) {
                super.onError(aVar, i, str);
                c.d("HistoryCommentsService", "fetchHistoryComments error: " + str);
                by.postOnUiThread(new bi() { // from class: com.kwad.components.core.innerEc.live.comment.history.b.2.2
                    @Override // com.kwad.sdk.utils.bi
                    public final void doTask() {
                        c.c("HistoryCommentsService", "fetchHistoryComments error", str);
                        b.this.f(new Throwable(str));
                    }
                });
            }
        });
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(HistoryCommentsResponse historyCommentsResponse) {
        b(historyCommentsResponse);
    }

    private void b(HistoryCommentsResponse historyCommentsResponse) {
        Iterator<a> it = this.TX.iterator();
        while (it.hasNext()) {
            it.next().c(historyCommentsResponse);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void f(Throwable th) {
        Iterator<a> it = this.TX.iterator();
        while (it.hasNext()) {
            it.next().rO();
        }
    }
}
