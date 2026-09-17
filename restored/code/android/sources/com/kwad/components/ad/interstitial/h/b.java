package com.kwad.components.ad.interstitial.h;

import android.graphics.drawable.ColorDrawable;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.components.core.proxy.j;
import com.kwad.components.core.widget.KSCornerImageView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import kotlinx.coroutines.scheduling.WorkQueueKt;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends j implements View.OnClickListener {
    private static boolean or;
    private TextView fH;
    private TextView kG;
    private AdTemplate mAdTemplate;
    private com.kwad.components.ad.interstitial.f.c mF;
    private KSCornerImageView on;
    private TextView oo;
    private TextView op;
    private TextView oq;

    public static void f(com.kwad.components.ad.interstitial.f.c cVar) {
        if (or) {
            return;
        }
        or = true;
        b bVar = new b();
        Bundle bundle = new Bundle();
        bundle.putString("KEY_TEMPLATE", cVar.mAdTemplate.toJson().toString());
        bVar.setArguments(bundle);
        bVar.g(cVar);
        bVar.show(cVar.lp.getOwnerActivity().getFragmentManager(), "interstitialCloseDialog");
    }

    @Override // com.kwad.components.core.proxy.j
    public final View a(LayoutInflater layoutInflater, ViewGroup viewGroup) {
        String string = getArguments().getString("KEY_TEMPLATE");
        try {
            AdTemplate adTemplate = new AdTemplate();
            this.mAdTemplate = adTemplate;
            adTemplate.parseJson(new JSONObject(string));
        } catch (JSONException e) {
            e.printStackTrace();
        }
        View viewInflate = layoutInflater.inflate(R.layout.ksad_interstitial_exit_intercept_dialog, viewGroup);
        i(viewInflate);
        initData();
        return viewInflate;
    }

    @Override // android.app.DialogFragment, android.app.Fragment
    public final void onActivityCreated(Bundle bundle) {
        super.onActivityCreated(bundle);
        Window window = getDialog().getWindow();
        if (window == null) {
            return;
        }
        getDialog().setCanceledOnTouchOutside(false);
        window.setLayout(-1, -1);
        getDialog().getWindow().setBackgroundDrawable(new ColorDrawable(0));
        setCancelable(false);
        com.kwad.components.ad.interstitial.f.c cVar = this.mF;
        if (cVar != null) {
            com.kwad.sdk.core.adlog.c.d(cVar.mAdTemplate, new JSONObject(), new com.kwad.sdk.core.adlog.c.b().dU(149).dZ(9));
        }
    }

    private void i(View view) {
        this.on = (KSCornerImageView) view.findViewById(R.id.ksad_interstitial_intercept_app_icon);
        this.kG = (TextView) view.findViewById(R.id.ksad_interstitial_intercept_app_title);
        this.fH = (TextView) view.findViewById(R.id.ksad_interstitial_intercept_dialog_desc);
        this.oo = (TextView) view.findViewById(R.id.ksad_interstitial_intercept_dialog_detail);
        this.op = (TextView) view.findViewById(R.id.ksad_interstitial_intercept_dialog_btn_continue);
        TextView textView = (TextView) view.findViewById(R.id.ksad_interstitial_intercept_dialog_btn_deny);
        this.oq = textView;
        com.kwad.sdk.c.a.a.a(this, this.on, this.kG, this.fH, this.oo, this.op, textView);
    }

    private void initData() {
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(this.mAdTemplate);
        KSImageLoader.loadAppIcon(this.on, com.kwad.sdk.core.response.helper.a.cv(adInfoEM), this.mAdTemplate, 12);
        this.kG.setText(com.kwad.sdk.core.response.helper.a.cs(adInfoEM));
        this.fH.setText(com.kwad.sdk.core.response.helper.a.aA(adInfoEM));
        if (com.kwad.sdk.core.response.helper.a.cI(this.mAdTemplate)) {
            this.oo.setText(com.kwad.sdk.core.response.helper.a.aK(adInfoEM));
        }
    }

    private void g(com.kwad.components.ad.interstitial.f.c cVar) {
        this.mF = cVar;
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        if (this.mF != null) {
            if (view.equals(this.on)) {
                com.kwad.components.ad.interstitial.f.c cVar = this.mF;
                cVar.a(cVar.lp.getContext(), WorkQueueKt.MASK, 2, 9);
            } else if (view.equals(this.kG)) {
                com.kwad.components.ad.interstitial.f.c cVar2 = this.mF;
                cVar2.a(cVar2.lp.getContext(), 128, 2, 9);
            } else if (view.equals(this.fH)) {
                com.kwad.components.ad.interstitial.f.c cVar3 = this.mF;
                cVar3.a(cVar3.lp.getContext(), 129, 2, 9);
            } else if (view.equals(this.oo)) {
                com.kwad.components.ad.interstitial.f.c cVar4 = this.mF;
                cVar4.a(cVar4.lp.getContext(), 131, 2, 9);
            } else if (view.equals(this.op)) {
                com.kwad.sdk.core.adlog.c.c(this.mF.mAdTemplate, (JSONObject) null, new com.kwad.sdk.core.adlog.c.b().dZ(9));
            } else if (view.equals(this.oq)) {
                com.kwad.components.ad.interstitial.f.c cVar5 = this.mF;
                cVar5.a(false, -1, cVar5.cB);
                this.mF.lp.dismiss();
                com.kwad.sdk.core.adlog.c.e(this.mF.mAdTemplate, null, new com.kwad.sdk.core.adlog.c.b().dU(MediaPlayer.MEDIA_PLAYER_OPTION_GET_CONTAINER_FPS).dZ(9));
            }
        }
        dismiss();
        or = false;
    }
}
