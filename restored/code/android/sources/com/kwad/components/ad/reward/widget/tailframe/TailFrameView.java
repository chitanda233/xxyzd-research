package com.kwad.components.ad.reward.widget.tailframe;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import com.kwad.components.ad.reward.g;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.helper.e;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.widget.KSFrameLayout;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class TailFrameView extends KSFrameLayout {
    private com.kwad.components.ad.reward.widget.tailframe.a FY;
    private g ub;

    public TailFrameView(Context context) {
        super(context);
    }

    public TailFrameView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
    }

    public TailFrameView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
    }

    public TailFrameView(Context context, View view) {
        super(context, view);
    }

    public void setCallerContext(g gVar) {
        this.ub = gVar;
    }

    public final void a(com.kwad.components.ad.reward.widget.tailframe.b bVar) {
        this.FY.setCallerContext(this.ub);
        this.FY.a(this.ub.mAdTemplate, this.ub.mReportExtData, bVar);
    }

    public final void a(Context context, boolean z, boolean z2) {
        g(z, z2);
        this.FY.B(context);
        this.FY.g(z, z2);
        addView(this.FY.lM(), -1, -1);
    }

    public final void lu() {
        this.FY.lu();
    }

    public final void destroy() {
        com.kwad.components.ad.reward.widget.tailframe.a aVar = this.FY;
        if (aVar != null) {
            aVar.destroy();
        }
    }

    private void g(boolean z, boolean z2) {
        if (this.FY != null) {
            return;
        }
        if (z) {
            if (z2) {
                this.FY = new d();
                return;
            } else {
                this.FY = new c();
                return;
            }
        }
        if (z2) {
            this.FY = new b();
        } else {
            this.FY = new a();
        }
    }

    static class d extends com.kwad.components.ad.reward.widget.tailframe.a {
        public d() {
            super(R.layout.ksad_video_tf_view_portrait_vertical);
        }

        @Override // com.kwad.components.ad.reward.widget.tailframe.a
        public final void a(AdTemplate adTemplate, JSONObject jSONObject, com.kwad.components.ad.reward.widget.tailframe.b bVar) {
            super.a(adTemplate, jSONObject, bVar);
            if (e.O(this.mAdTemplate)) {
                this.FO.setBackground(null);
                this.FP.setVisibility(8);
                this.mLogoView.setVisibility(8);
            }
            KSImageLoader.loadImage(this.FP, com.kwad.sdk.core.response.helper.a.aa(this.mAdInfo), this.mAdTemplate);
        }
    }

    static class c extends com.kwad.components.ad.reward.widget.tailframe.a implements com.kwad.sdk.widget.d {
        private View Gc;

        public c() {
            super(R.layout.ksad_video_tf_view_portrait_horizontal);
        }

        @Override // com.kwad.components.ad.reward.widget.tailframe.a
        public final void B(Context context) {
            super.B(context);
            this.Gc = this.FO.findViewById(R.id.video_cover);
        }

        @Override // com.kwad.components.ad.reward.widget.tailframe.a
        public final void a(AdTemplate adTemplate, JSONObject jSONObject, com.kwad.components.ad.reward.widget.tailframe.b bVar) {
            super.a(adTemplate, jSONObject, bVar);
            if (e.O(this.mAdTemplate)) {
                this.Gc.setVisibility(8);
                this.mLogoView.setVisibility(8);
                this.FO.setBackground(null);
            }
            lQ();
        }

        private void lQ() {
            AdInfo.AdMaterialInfo.MaterialFeature materialFeatureBd = com.kwad.sdk.core.response.helper.a.bd(this.mAdInfo);
            int i = materialFeatureBd.width;
            int i2 = materialFeatureBd.height;
            int screenWidth = com.kwad.sdk.c.a.a.getScreenWidth(this.FO.getContext());
            int i3 = (int) (screenWidth * (i2 / i));
            ViewGroup.LayoutParams layoutParams = this.FP.getLayoutParams();
            layoutParams.width = screenWidth;
            layoutParams.height = i3;
            KSImageLoader.loadImage(this.FP, materialFeatureBd.coverUrl, this.mAdTemplate);
        }
    }

    static class b extends com.kwad.components.ad.reward.widget.tailframe.a implements com.kwad.sdk.widget.d {
        private ImageView FZ;
        private ImageView Ga;
        private ImageView Gb;

        public b() {
            super(R.layout.ksad_video_tf_view_landscape_vertical);
        }

        @Override // com.kwad.components.ad.reward.widget.tailframe.a
        public final void B(Context context) {
            super.B(context);
            this.FZ = (ImageView) this.FO.findViewById(R.id.ksad_video_thumb_left);
            this.Ga = (ImageView) this.FO.findViewById(R.id.ksad_video_thumb_mid);
            this.Gb = (ImageView) this.FO.findViewById(R.id.ksad_video_thumb_right);
        }

        @Override // com.kwad.components.ad.reward.widget.tailframe.a
        public final void a(AdTemplate adTemplate, JSONObject jSONObject, com.kwad.components.ad.reward.widget.tailframe.b bVar) {
            super.a(adTemplate, jSONObject, bVar);
            lQ();
        }

        private void lQ() {
            KSImageLoader.loadImage(this.FZ, com.kwad.sdk.core.response.helper.a.aa(this.mAdInfo), this.mAdTemplate);
            KSImageLoader.loadImage(this.Ga, com.kwad.sdk.core.response.helper.a.aa(this.mAdInfo), this.mAdTemplate);
            KSImageLoader.loadImage(this.Gb, com.kwad.sdk.core.response.helper.a.aa(this.mAdInfo), this.mAdTemplate);
        }
    }

    static class a extends com.kwad.components.ad.reward.widget.tailframe.a implements com.kwad.sdk.widget.d {
        public a() {
            super(R.layout.ksad_video_tf_view_landscape_horizontal);
        }

        @Override // com.kwad.components.ad.reward.widget.tailframe.a
        public final void a(AdTemplate adTemplate, JSONObject jSONObject, com.kwad.components.ad.reward.widget.tailframe.b bVar) {
            super.a(adTemplate, jSONObject, bVar);
            KSImageLoader.loadImage(this.FP, com.kwad.sdk.core.response.helper.a.aa(this.mAdInfo), this.mAdTemplate);
        }
    }
}
