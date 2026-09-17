package com.kwad.components.ad.reward.presenter.d;

import com.kwad.components.ad.reward.e.g;
import com.kwad.components.ad.reward.e.j;
import com.kwad.components.ad.reward.e.n;
import com.kwad.components.ad.reward.presenter.d.b.c;
import com.kwad.components.ad.reward.presenter.d.b.d;
import com.kwad.components.core.playable.PlayableSource;
import com.kwad.sdk.mvp.Presenter;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class a extends com.kwad.components.ad.reward.presenter.b implements g, j {
    @Override // com.kwad.components.ad.reward.e.j
    public final void a(PlayableSource playableSource, n nVar) {
    }

    @Override // com.kwad.components.ad.reward.e.j
    /* JADX INFO: renamed from: do */
    public final void mo174do() {
    }

    @Override // com.kwad.components.ad.reward.e.g
    public final int getPriority() {
        return 0;
    }

    public a() {
        dx();
    }

    protected void dx() {
        a(new d());
        a(new com.kwad.components.ad.reward.presenter.d.b.a());
        a(new com.kwad.components.ad.reward.presenter.d.b.b());
    }

    @Override // com.kwad.components.ad.reward.presenter.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        dq();
    }

    private void dq() {
        this.ub.b(this);
        com.kwad.components.ad.reward.a.gq().a(this);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        this.ub.c(this);
        com.kwad.components.ad.reward.a.gq().b(this);
    }

    @Override // com.kwad.components.ad.reward.e.g
    public final void cZ() {
        ff();
    }

    private void ff() {
        List<Presenter> listSJ = SJ();
        if (listSJ == null) {
            return;
        }
        for (Object obj : listSJ) {
            if (obj instanceof c) {
                ((c) obj).jY();
            }
        }
    }

    @Override // com.kwad.components.ad.reward.e.j
    public final void dp() {
        ff();
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // java.lang.Comparable
    /* JADX INFO: renamed from: a, reason: merged with bridge method [inline-methods] */
    public int compareTo(g gVar) {
        return getPriority() - gVar.getPriority();
    }
}
