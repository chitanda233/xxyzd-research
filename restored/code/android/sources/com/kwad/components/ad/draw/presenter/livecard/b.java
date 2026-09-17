package com.kwad.components.ad.draw.presenter.livecard;

import android.view.View;
import android.widget.TextView;
import com.kwad.components.offline.api.core.adlive.IAdLivePlayModule;
import com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener;
import com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter;
import com.kwad.sdk.R;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.widget.KSFrameLayout;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends com.kwad.components.ad.draw.b.a implements View.OnClickListener {
    private IAdLivePlayModule dO;
    private KSFrameLayout eo;
    private KsLiveAuthorView ep;
    private TextView eq;
    private TextView er;
    private TextView es;
    private final AdLivePlayStateListener et = new AdLivePlayStateListenerAdapter() { // from class: com.kwad.components.ad.draw.presenter.livecard.b.1
        @Override // com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListenerAdapter, com.kwad.components.offline.api.core.adlive.listener.AdLivePlayStateListener
        public final void onLivePlayEnd() {
            super.onLivePlayEnd();
            if (b.this.eo != null) {
                b.this.eo.setVisibility(0);
            }
        }
    };
    private AdInfo mAdInfo;
    private AdTemplate mAdTemplate;

    @Override // com.kwad.components.ad.draw.b.a, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        this.dO = this.dL.dO;
        AdTemplate adTemplate = this.dL.mAdTemplate;
        this.mAdTemplate = adTemplate;
        this.mAdInfo = e.eM(adTemplate);
        if (this.dO == null) {
            return;
        }
        initView();
        aU();
    }

    private void aU() {
        this.dO.registerAdLivePlayStateListener(this.et);
        this.eo.setOnClickListener(this);
        this.ep.setOnClickListener(this);
        this.er.setOnClickListener(this);
        this.es.setOnClickListener(this);
        this.eq.setOnClickListener(this);
    }

    private void initView() {
        KSFrameLayout kSFrameLayout = (KSFrameLayout) findViewById(R.id.ksad_draw_live_end);
        this.eo = kSFrameLayout;
        this.ep = (KsLiveAuthorView) kSFrameLayout.findViewById(R.id.ksad_draw_author_icon);
        this.eq = (TextView) this.eo.findViewById(R.id.ksad_draw_live_end_app_name);
        this.es = (TextView) this.eo.findViewById(R.id.ksad_live_actionbar_btn);
        this.er = (TextView) this.eo.findViewById(R.id.ksad_draw_live_end_text);
        this.ep.j(this.dL.mAdTemplate);
        this.eq.setText(com.kwad.sdk.core.response.helper.a.cs(this.mAdInfo));
        this.er.setText(com.kwad.sdk.core.response.helper.a.aA(this.mAdInfo));
        this.es.setText(com.kwad.sdk.core.response.helper.a.aK(this.mAdInfo));
        this.eo.setVisibility(8);
    }

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onUnbind() {
        super.onUnbind();
        IAdLivePlayModule iAdLivePlayModule = this.dO;
        if (iAdLivePlayModule == null) {
            return;
        }
        iAdLivePlayModule.unRegisterAdLivePlayStateListener(this.et);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (view.equals(this.eo)) {
            this.dL.a(2, view.getContext(), 53, 2);
            return;
        }
        if (view.equals(this.ep)) {
            this.dL.a(2, view.getContext(), 15, 2);
            return;
        }
        if (view.equals(this.er)) {
            this.dL.a(2, view.getContext(), 17, 2);
        } else if (view.equals(this.eq)) {
            this.dL.a(2, view.getContext(), 16, 2);
        } else if (view.equals(this.es)) {
            this.dL.a(2, view.getContext(), 26, 1);
        }
    }
}
