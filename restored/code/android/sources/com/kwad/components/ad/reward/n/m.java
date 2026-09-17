package com.kwad.components.ad.reward.n;

import android.app.DialogFragment;
import android.text.SpannableString;
import android.text.style.ForegroundColorSpan;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class m extends d implements View.OnClickListener {
    private DialogFragment DL;
    private View DO;
    private ViewGroup Eb;
    private View Ec;
    private TextView Ed;
    private TextView Ee;
    private TextView Ef;
    private View Eg;
    private ImageView ix;
    private TextView kG;
    private com.kwad.components.ad.reward.h.a tA;

    public m(DialogFragment dialogFragment, AdTemplate adTemplate, LayoutInflater layoutInflater, ViewGroup viewGroup, com.kwad.components.ad.reward.h.a aVar) {
        this.DL = dialogFragment;
        this.tA = aVar;
        if (com.kwad.sdk.core.response.helper.a.cY(com.kwad.sdk.core.response.helper.e.eM(adTemplate))) {
            this.Eb = (ViewGroup) layoutInflater.inflate(R.layout.ksad_live_origin_dialog, viewGroup, false);
            t(true);
        } else {
            this.Eb = (ViewGroup) layoutInflater.inflate(R.layout.ksad_live_subscribe_dialog, viewGroup, false);
            t(false);
        }
    }

    private void t(boolean z) {
        this.Ec = this.Eb.findViewById(R.id.ksad_live_subscribe_dialog_btn_close);
        this.kG = (TextView) this.Eb.findViewById(R.id.ksad_live_subscribe_dialog_title);
        this.ix = (ImageView) this.Eb.findViewById(R.id.ksad_live_subscribe_dialog_icon);
        this.Ee = (TextView) this.Eb.findViewById(R.id.ksad_live_subscribe_dialog_content_txt);
        this.Ed = (TextView) this.Eb.findViewById(R.id.ksad_live_subscribe_dialog_content);
        this.DO = this.Eb.findViewById(R.id.ksad_live_subscribe_dialog_btn_continue);
        this.Eg = this.Eb.findViewById(R.id.ksad_live_subscribe_dialog_btn_deny);
        this.Ef = (TextView) this.Eb.findViewById(R.id.ksad_live_subscribe_dialog_vide_detail);
        if (z) {
            this.Ec.setVisibility(8);
        }
        this.Ec.setOnClickListener(this);
        this.DO.setOnClickListener(this);
        this.Eg.setOnClickListener(this);
        this.Ef.setOnClickListener(this);
    }

    public final void a(com.kwad.components.ad.reward.h.c cVar) {
        KSImageLoader.loadCircleIcon(this.ix, cVar.hy(), this.Eb.getContext().getResources().getDrawable(R.drawable.ksad_ic_default_user_avatar));
        String title = cVar.getTitle();
        if (this.kG != null && title != null) {
            SpannableString spannableString = new SpannableString(title);
            int color = hZ().getResources().getColor(R.color.ksad_reward_main_color);
            spannableString.setSpan(new ForegroundColorSpan(color), 2, 4, 18);
            ForegroundColorSpan foregroundColorSpan = new ForegroundColorSpan(color);
            int length = title.length();
            spannableString.setSpan(foregroundColorSpan, length - 2, length, 18);
            this.kG.setText(spannableString);
        }
        this.Ed.setText(cVar.hz());
        this.Ee.setText(cVar.hA());
        this.Ef.setText(String.format("%s", cVar.tJ));
    }

    @Override // com.kwad.components.ad.reward.n.d
    public final ViewGroup hZ() {
        return this.Eb;
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        com.kwad.components.ad.reward.h.a aVar;
        if (view.equals(this.Ec)) {
            this.DL.dismiss();
            com.kwad.components.ad.reward.h.a aVar2 = this.tA;
            if (aVar2 != null) {
                aVar2.ht();
                return;
            }
            return;
        }
        if (view.equals(this.DO)) {
            this.DL.dismiss();
            com.kwad.components.ad.reward.h.a aVar3 = this.tA;
            if (aVar3 != null) {
                aVar3.ht();
                return;
            }
            return;
        }
        if (view.equals(this.Eg)) {
            this.DL.dismiss();
            com.kwad.components.ad.reward.h.a aVar4 = this.tA;
            if (aVar4 != null) {
                aVar4.H(false);
                return;
            }
            return;
        }
        if (!view.equals(this.Ef) || (aVar = this.tA) == null) {
            return;
        }
        aVar.h(131, 2);
    }
}
