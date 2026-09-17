package com.kwad.components.ad.reward;

import android.view.MotionEvent;
import android.view.View;
import android.widget.FrameLayout;
import com.kwad.components.core.webview.jshandler.y;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.view.AdBaseFrameLayout;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends com.kwad.components.ad.l.b {
    private List<AdTemplate> si;
    private boolean sj;
    private List<com.kwad.components.core.e.d.d> sk;
    private y.b sl;

    @Override // com.kwad.components.ad.l.b
    public final boolean gD() {
        return false;
    }

    @Override // com.kwad.components.ad.l.b
    public final String getName() {
        return "MiddlePlayEndCard";
    }

    public d(List<AdTemplate> list, JSONObject jSONObject, y.b bVar) {
        super(jSONObject, null);
        this.sj = false;
        this.sk = new ArrayList();
        this.si = list;
        this.sl = bVar;
        if (list == null || list.size() <= 0) {
            return;
        }
        Iterator<AdTemplate> it = this.si.iterator();
        while (it.hasNext()) {
            this.sk.add(new com.kwad.components.core.e.d.d(it.next()));
        }
    }

    @Override // com.kwad.components.ad.l.b
    public final void a(FrameLayout frameLayout, AdBaseFrameLayout adBaseFrameLayout, AdTemplate adTemplate, com.kwad.components.core.e.d.d dVar, int i) {
        super.a(frameLayout, adBaseFrameLayout, this.si, this.sk);
    }

    @Override // com.kwad.components.ad.l.b
    public final void gC() {
        super.gC();
        this.eZ.setOnTouchListener(new View.OnTouchListener() { // from class: com.kwad.components.ad.reward.d.1
            @Override // android.view.View.OnTouchListener
            public final boolean onTouch(View view, MotionEvent motionEvent) {
                return motionEvent.getAction() == 2;
            }
        });
    }

    public final void gE() {
        if (this.ff != null) {
            this.ff.yK();
        }
    }

    @Override // com.kwad.components.ad.l.b
    public final String K(AdTemplate adTemplate) {
        List<AdTemplate> list = this.si;
        if (list == null || list.size() < 2) {
            return super.K(adTemplate);
        }
        return com.kwad.sdk.core.response.helper.b.cU(this.si.get(1));
    }

    public final void setShowLandingPage(boolean z) {
        this.sj = z;
    }

    @Override // com.kwad.components.ad.l.b
    public final void b(com.kwad.sdk.core.webview.b bVar) {
        bVar.setAdTemplateList(this.si);
    }

    @Override // com.kwad.components.ad.l.b
    public final void a(com.kwad.components.core.webview.a aVar) {
        super.a(aVar);
        List<AdTemplate> list = this.si;
        y yVar = new y(new ArrayList(list.subList(1, list.size() - 1)));
        yVar.a(this.sl);
        aVar.a(yVar);
    }

    @Override // com.kwad.components.ad.l.b
    public final void gF() {
        com.kwad.components.ad.reward.monitor.d.a(true, "middle_play_end_card");
    }

    @Override // com.kwad.components.ad.l.b
    public final void gG() {
        com.kwad.components.ad.reward.monitor.d.a(this.mAdTemplate, true, "middle_play_end_card", K(this.mAdTemplate));
    }

    @Override // com.kwad.components.ad.l.b
    public final void gH() {
        com.kwad.components.ad.reward.monitor.d.a(true, "middle_play_end_card", K(this.mAdTemplate), System.currentTimeMillis() - getLoadTime());
    }

    @Override // com.kwad.components.ad.l.b
    public final boolean cJ() {
        if (this.sj) {
            return this.NJ;
        }
        return super.cJ();
    }
}
