package com.kwad.components.core.innerEc.live.b;

import android.os.Bundle;
import android.view.View;
import com.kwad.components.core.c.f;
import com.kwad.components.core.innerEc.live.b.a.b;
import com.kwad.components.core.innerEc.live.b.c.d;
import com.kwad.components.core.innerEc.live.b.c.g;
import com.kwad.components.core.innerEc.live.b.c.h;
import com.kwad.components.core.innerEc.live.b.c.i;
import com.kwad.components.core.innerEc.live.b.c.j;
import com.kwad.components.core.innerEc.live.i.e;
import com.kwad.components.core.innerEc.live.slide.LiveDetailActivity;
import com.kwad.components.core.n.c;
import com.kwad.components.offline.api.core.adInnerEc.fullAdLive.ILiveBindOwner;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.model.AdResultData;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.core.scene.URLPackage;
import com.kwad.sdk.mvp.Presenter;
import com.kwad.sdk.utils.ac;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class a extends c {
    private int UG = 0;
    private String UH;
    private AdResultData mAdResultData;
    private AdTemplate mAdTemplate;

    public a() {
        setRetainInstance(true);
    }

    public final AdResultData iF() {
        return this.mAdResultData;
    }

    @Override // com.kwad.components.core.proxy.h, com.kwad.sdk.api.core.fragment.KsFragment, com.kwad.sdk.api.core.fragment.AbstractIFragmentLifecycle, com.kwad.sdk.api.core.fragment.IFragmentLifecycle
    public final void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        this.mAdResultData = f.oR().d(getArguments().getInt(LiveDetailActivity.KEY_AD_RESULT_CACHE_IDX, 0), true);
        com.kwad.sdk.core.d.c.d("LiveDetailFragment", this + "onCreate:" + this.mAdResultData);
        AdResultData adResultData = this.mAdResultData;
        if (adResultData == null) {
            com.kwad.sdk.core.d.c.d("LiveDetailFragment", this + "onViewCreated: mAdResultData is null");
            return;
        }
        AdTemplate firstAdTemplate = adResultData.getFirstAdTemplate();
        this.mAdTemplate = firstAdTemplate;
        com.kwad.components.core.innerEc.logger.a.aP(firstAdTemplate);
    }

    @Override // com.kwad.sdk.api.core.fragment.KsFragment, com.kwad.sdk.api.core.fragment.AbstractIFragmentLifecycle, com.kwad.sdk.api.core.fragment.IFragmentLifecycle
    public final void onViewCreated(View view, Bundle bundle) {
        com.kwad.sdk.core.d.c.d("LiveDetailFragment", this + "onViewCreated:" + bundle);
        if (getArguments() == null) {
            com.kwad.sdk.core.d.c.e("LiveDetailFragment", "bundle is null");
            return;
        }
        AdTemplate adTemplate = this.mAdTemplate;
        if (adTemplate == null) {
            com.kwad.sdk.core.d.c.d("LiveDetailFragment", this + "onViewCreated: mAdTemplate is null");
            return;
        }
        this.UH = e.e(adTemplate, this.UG);
        com.kwad.components.core.innerEc.logger.a.aQ(this.mAdTemplate);
        super.onViewCreated(view, bundle);
    }

    @Override // com.kwad.components.core.n.c, com.kwad.sdk.api.core.fragment.KsFragment, com.kwad.sdk.api.core.fragment.AbstractIFragmentLifecycle, com.kwad.sdk.api.core.fragment.IFragmentLifecycle
    public final void onDestroyView() {
        super.onDestroyView();
    }

    @Override // com.kwad.components.core.n.c
    public final void onActivityDestroy() {
        super.onActivityDestroy();
        com.kwad.sdk.core.d.c.d("LiveDetailFragment", this + "onActivityDestroy:");
        this.mPresenter = null;
    }

    @Override // com.kwad.components.core.proxy.h
    public final int rU() {
        return R.layout.ksad_live_play_fragment_layout;
    }

    /* JADX INFO: Access modifiers changed from: private */
    @Override // com.kwad.components.core.n.c
    /* JADX INFO: renamed from: rV, reason: merged with bridge method [inline-methods] */
    public b an() {
        b bVar = new b();
        ILiveBindOwner iLiveBindOwnerA = com.kwad.components.core.innerEc.f.a(getActivity().getApplication(), this.UH, rW(), new com.kwad.components.core.innerEc.live.b.b.a());
        bVar.UL = iLiveBindOwnerA;
        bVar.mAdResultData = this.mAdResultData;
        bVar.UK = this;
        bVar.UZ = new com.kwad.components.core.innerEc.live.d.b();
        com.kwad.sdk.core.d.c.d("LiveDetailFragment", "jky onCreateCallerContext: callerContext.mTKLoadObserve is: " + bVar.UZ);
        if (iLiveBindOwnerA != null) {
            bVar.UR = new com.kwad.components.core.innerEc.live.video.a.b(iLiveBindOwnerA.getLivePlayer());
            bVar.UQ = iLiveBindOwnerA.getLongConnection();
        }
        bVar.UT = new com.kwad.components.core.innerEc.live.end.b();
        bVar.UQ.init();
        bVar.UN = new com.kwad.components.core.innerEc.live.config.b(this.mAdTemplate);
        bVar.UO = new com.kwad.components.core.innerEc.live.end.b();
        bVar.UM = new com.kwad.components.core.widget.a.b(this, this.ou, 70);
        bVar.mAdTemplate = this.mAdTemplate;
        bVar.US = new com.kwad.components.core.innerEc.live.c.a(getActivity(), bVar);
        return bVar;
    }

    private String rW() {
        JSONObject jSONObject = new JSONObject();
        ac.putValue(jSONObject, URLPackage.KEY_AUTHOR_ID, e.aJ(this.mAdTemplate));
        return jSONObject.toString();
    }

    @Override // com.kwad.components.core.n.c
    public final Presenter onCreatePresenter() {
        com.kwad.sdk.core.d.c.d("LiveDetailFragment", this + "onCreatePresenter:");
        Presenter presenter = new Presenter();
        presenter.a(new com.kwad.components.core.innerEc.live.b.c.e());
        presenter.a(new d());
        presenter.a(new i());
        presenter.a(new com.kwad.components.core.innerEc.live.b.c.b());
        presenter.a(new com.kwad.components.core.innerEc.live.b.c.c());
        presenter.a(new g());
        presenter.a(new h());
        presenter.a(new com.kwad.components.core.innerEc.live.b.c.a());
        presenter.a(new j());
        presenter.a(new com.kwad.components.core.innerEc.live.b.c.f());
        return presenter;
    }
}
