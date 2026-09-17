package com.kwad.components.ad.reward.n;

import android.content.Context;
import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewStub;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.ad.widget.KsPriceView;
import com.kwad.components.core.widget.KSCornerImageView;
import com.kwad.components.core.widget.KsStyledTextButton;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.helper.SlideConvertHelper;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class k extends d implements com.kwad.sdk.widget.d {
    private ViewStub DP;
    private ViewGroup DQ;
    private KsStyledTextButton DR;
    private KsStyledTextButton DS;
    private KsPriceView Dr;
    private TextView Du;
    private TextView Dv;
    private View Dw;
    private TextView fH;
    private TextView kG;
    private KSCornerImageView on;
    private com.kwad.components.ad.reward.g ub;

    public k(com.kwad.components.ad.reward.g gVar, ViewStub viewStub) {
        this.DP = viewStub;
        this.ub = gVar;
    }

    public k(com.kwad.components.ad.reward.g gVar, ViewGroup viewGroup) {
        this.DQ = viewGroup;
        this.ub = gVar;
    }

    public final void hide() {
        ViewGroup viewGroup = this.DQ;
        if (viewGroup != null) {
            viewGroup.setVisibility(8);
        }
    }

    @Override // com.kwad.components.ad.reward.n.d
    public final ViewGroup hZ() {
        return this.DQ;
    }

    @Override // com.kwad.components.ad.reward.n.d
    public final void a(r rVar) {
        super.a(rVar);
        a(rVar.getAdTemplate(), com.kwad.components.ad.reward.model.a.R(rVar.getAdTemplate()));
    }

    private void a(AdTemplate adTemplate, com.kwad.components.ad.reward.model.a aVar) {
        KSImageLoader.loadAppIcon(this.on, aVar.hy(), adTemplate, 8);
        this.kG.setText(aVar.getTitle());
        this.fH.setText(aVar.hz());
        int dimensionPixelSize = this.DQ.getResources().getDimensionPixelSize(R.dimen.ksad_reward_jinniu_end_origin_text_size);
        this.Dr.getConfig().au(dimensionPixelSize).aw(dimensionPixelSize).av(this.DQ.getResources().getColor(R.color.ksad_jinniu_end_origin_color));
        this.Dr.d(aVar.getPrice(), aVar.getOriginPrice(), true);
        String strIq = aVar.iq();
        this.Dw.setVisibility(TextUtils.isEmpty(strIq) ? 8 : 0);
        if (strIq != null) {
            this.Du.setText(strIq);
        }
        this.Dv.setText(aVar.ir());
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view) {
        f(view, true);
    }

    @Override // com.kwad.sdk.widget.d
    public final void a(View view, float f, float f2, float f3, float f4) {
        if (SlideConvertHelper.a(this.ub.mAdTemplate, f, f2, f3, f4)) {
            f(view, false);
        }
    }

    private void f(View view, boolean z) {
        boolean zEquals = view.equals(this.DS);
        int i = MediaPlayer.MEDIA_PLAYER_OPTION_GET_DROP_COUNT;
        if (zEquals) {
            com.kwad.components.ad.reward.g gVar = this.ub;
            Context context = view.getContext();
            if (z) {
                i = 38;
            }
            gVar.a(2, context, i, 1);
            return;
        }
        if (view.equals(this.DR)) {
            com.kwad.components.ad.reward.g gVar2 = this.ub;
            Context context2 = view.getContext();
            if (z) {
                i = 37;
            }
            gVar2.a(2, context2, i, 1);
            return;
        }
        if (view.equals(this.DQ)) {
            com.kwad.components.ad.reward.g gVar3 = this.ub;
            Context context3 = view.getContext();
            if (z) {
                i = 2;
            }
            gVar3.a(2, context3, i, 2);
        }
    }
}
