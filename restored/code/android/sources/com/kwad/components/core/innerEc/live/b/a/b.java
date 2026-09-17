package com.kwad.components.core.innerEc.live.b.a;

import com.kwad.components.core.innerEc.live.a.e;
import com.kwad.components.core.innerEc.live.a.p;
import com.kwad.components.core.innerEc.live.config.net.g;
import com.kwad.components.core.innerEc.live.widget.h;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.ILiveBindOwner;
import com.kwad.components.offline.api.core.adInnerEc.longconnection.ILiveLongConnection;
import com.kwad.sdk.api.core.fragment.KsFragment;
import com.kwad.sdk.core.response.model.AdResultData;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.sdk.mvp.a {
    public String TG;
    public com.kwad.components.core.innerEc.live.base.a UI;
    public KsFragment UK;
    public ILiveBindOwner UL;
    public com.kwad.components.core.widget.a.b UM;
    public com.kwad.components.core.innerEc.live.config.b UN;
    public com.kwad.components.core.innerEc.live.end.a UO;
    public ILiveLongConnection UQ;
    public com.kwad.components.core.innerEc.live.video.a.b UR;
    public com.kwad.components.core.innerEc.live.c.a US;
    public com.kwad.components.core.innerEc.live.end.a UT;
    public h UU;
    public com.kwad.sdk.g.b<Object, Object> UW;
    public com.kwad.sdk.g.b<Object, Object> UY;
    public com.kwad.components.core.innerEc.live.d.b UZ;
    public p Va;
    public e Vb;
    public AdResultData mAdResultData;
    public List<com.kwad.components.core.k.a> UJ = new ArrayList();
    public g UV = new g();
    public List<com.kwad.sdk.g.b<Object, Object>> UX = new ArrayList();
    public String TF = "0";
    public boolean Vc = true;

    @Override // com.kwad.sdk.mvp.a
    public final void release() {
        this.US.destroy();
        this.UL.release();
    }
}
