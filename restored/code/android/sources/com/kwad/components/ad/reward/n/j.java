package com.kwad.components.ad.reward.n;

import android.app.DialogFragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import com.kwad.components.core.widget.KSCornerImageView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdTemplate;
import kotlinx.coroutines.scheduling.WorkQueueKt;

/* JADX INFO: loaded from: classes3.dex */
public final class j extends d implements View.OnClickListener {
    private DialogFragment DL;
    private TextView DM;
    private View DN;
    private View DO;
    private AdTemplate adTemplate;
    private TextView fH;
    private TextView kG;
    private KSCornerImageView on;
    private TextView oo;
    private com.kwad.components.ad.reward.h.a tA;
    private ViewGroup wL;
    private View zC;

    public j(DialogFragment dialogFragment, AdTemplate adTemplate, LayoutInflater layoutInflater, ViewGroup viewGroup, com.kwad.components.ad.reward.h.a aVar) {
        this.DL = dialogFragment;
        this.adTemplate = adTemplate;
        this.tA = aVar;
        this.wL = (ViewGroup) layoutInflater.inflate(R.layout.ksad_reward_jinniu_dialog, viewGroup, false);
        initView();
    }

    private void initView() {
        this.on = (KSCornerImageView) this.wL.findViewById(R.id.ksad_reward_jinniu_dialog_icon);
        this.kG = (TextView) this.wL.findViewById(R.id.ksad_reward_jinniu_dialog_title);
        this.fH = (TextView) this.wL.findViewById(R.id.ksad_reward_jinniu_dialog_desc);
        this.DM = (TextView) this.wL.findViewById(R.id.ksad_reward_jinniu_dialog_play_time_tips);
        this.oo = (TextView) this.wL.findViewById(R.id.ksad_reward_jinniu_dialog_detail);
        this.zC = this.wL.findViewById(R.id.ksad_reward_jinniu_dialog_btn_close);
        this.DN = this.wL.findViewById(R.id.ksad_reward_jinniu_dialog_btn_deny);
        this.DO = this.wL.findViewById(R.id.ksad_reward_jinniu_dialog_btn_continue);
        this.zC.setOnClickListener(this);
        this.DN.setOnClickListener(this);
        this.DO.setOnClickListener(this);
        this.on.setOnClickListener(this);
        this.kG.setOnClickListener(this);
        this.fH.setOnClickListener(this);
        this.oo.setOnClickListener(this);
    }

    public final void a(com.kwad.components.ad.reward.h.c cVar) {
        KSImageLoader.loadAppIcon(this.on, cVar.hy(), this.adTemplate, 4);
        this.kG.setText(cVar.getTitle());
        this.fH.setText(cVar.hz());
        this.DM.setText(cVar.hB());
        if (com.kwad.sdk.core.response.helper.a.cI(this.adTemplate)) {
            this.oo.setText(String.format("%s >", com.kwad.sdk.core.response.helper.a.aK(com.kwad.sdk.core.response.helper.e.eM(this.adTemplate))));
        }
    }

    @Override // com.kwad.components.ad.reward.n.d
    public final ViewGroup hZ() {
        return this.wL;
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        com.kwad.components.ad.reward.h.a aVar;
        if (view.equals(this.zC)) {
            this.DL.dismiss();
            com.kwad.components.ad.reward.h.a aVar2 = this.tA;
            if (aVar2 != null) {
                aVar2.ht();
                return;
            }
            return;
        }
        if (view.equals(this.DN)) {
            this.DL.dismiss();
            com.kwad.components.ad.reward.h.a aVar3 = this.tA;
            if (aVar3 != null) {
                aVar3.H(false);
                return;
            }
            return;
        }
        if (view.equals(this.DO)) {
            this.DL.dismiss();
            com.kwad.components.ad.reward.h.a aVar4 = this.tA;
            if (aVar4 != null) {
                aVar4.ht();
                return;
            }
            return;
        }
        if (view.equals(this.on)) {
            com.kwad.components.ad.reward.h.a aVar5 = this.tA;
            if (aVar5 != null) {
                aVar5.h(WorkQueueKt.MASK, 2);
                return;
            }
            return;
        }
        if (view.equals(this.kG)) {
            com.kwad.components.ad.reward.h.a aVar6 = this.tA;
            if (aVar6 != null) {
                aVar6.h(128, 2);
                return;
            }
            return;
        }
        if (view.equals(this.fH)) {
            com.kwad.components.ad.reward.h.a aVar7 = this.tA;
            if (aVar7 != null) {
                aVar7.h(129, 2);
                return;
            }
            return;
        }
        if (!view.equals(this.oo) || (aVar = this.tA) == null) {
            return;
        }
        aVar.h(131, 2);
    }
}
