package com.kwad.components.ad.reward.n;

import android.text.SpannableString;
import android.text.style.ForegroundColorSpan;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import com.kuaishou.weapon.p0.bg;
import com.kwad.components.ad.reward.model.AdLiveEndResultData;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;

/* JADX INFO: loaded from: classes3.dex */
public final class p extends s implements View.OnClickListener {
    private TextView EA;
    private TextView EB;
    private ImageView Eu;
    private TextView Ev;
    private TextView Ew;
    private TextView Ex;
    private TextView Ey;
    private TextView Ez;
    private com.kwad.components.ad.reward.g ub;

    public p(com.kwad.components.ad.reward.g gVar) {
        this.ub = gVar;
    }

    public final void j(ViewGroup viewGroup) {
        if (this.ub.mContext.getResources().getConfiguration().orientation == 2) {
            super.a(viewGroup, R.id.ksad_reward_origin_live_end_page_stub_landscape, R.id.ksad_live_end_page_layout_root_landscape);
        } else {
            super.a(viewGroup, R.id.ksad_reward_origin_live_end_page_stub, R.id.ksad_live_end_page_layout_root);
        }
        initView();
    }

    private void initView() {
        if (this.wL == null) {
            return;
        }
        if (this.ub.mContext.getResources().getConfiguration().orientation == 2) {
            this.Eu = (ImageView) this.wL.findViewById(R.id.ksad_live_end_page_author_icon_landscape);
            this.Ev = (TextView) this.wL.findViewById(R.id.ksad_author_name_txt_landscape);
            this.Ew = (TextView) this.wL.findViewById(R.id.ksad_live_end_detail_watch_person_count_landscape);
            this.Ex = (TextView) this.wL.findViewById(R.id.ksad_live_end_detail_like_person_count_landscape);
            this.Ey = (TextView) this.wL.findViewById(R.id.ksad_live_end_detail_watch_time_landscape);
            this.Ez = (TextView) this.wL.findViewById(R.id.ksad_live_end_bottom_title_landscape);
            this.EA = (TextView) this.wL.findViewById(R.id.ksad_live_end_bottom_action_btn_landscape);
            this.EB = (TextView) this.wL.findViewById(R.id.ksad_live_end_bottom_des_btn_landscape);
        } else {
            this.Eu = (ImageView) this.wL.findViewById(R.id.ksad_live_end_page_author_icon);
            this.Ev = (TextView) this.wL.findViewById(R.id.ksad_author_name_txt);
            this.Ew = (TextView) this.wL.findViewById(R.id.ksad_live_end_detail_watch_person_count);
            this.Ex = (TextView) this.wL.findViewById(R.id.ksad_live_end_detail_like_person_count);
            this.Ey = (TextView) this.wL.findViewById(R.id.ksad_live_end_detail_watch_time);
            this.Ez = (TextView) this.wL.findViewById(R.id.ksad_live_end_bottom_title);
            this.EA = (TextView) this.wL.findViewById(R.id.ksad_live_end_bottom_action_btn);
            this.EB = (TextView) this.wL.findViewById(R.id.ksad_live_end_bottom_des_btn);
        }
        this.EA.setOnClickListener(this);
        this.EB.setOnClickListener(this);
    }

    @Override // com.kwad.components.ad.reward.n.d
    protected final void a(r rVar) {
        super.a(rVar);
        j(rVar.getAdTemplate());
    }

    private void j(AdTemplate adTemplate) {
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        KSImageLoader.loadCircleIcon(this.Eu, com.kwad.sdk.core.response.helper.a.cv(adInfoEM), this.Eu.getResources().getDrawable(R.drawable.ksad_ic_default_user_avatar));
        this.Ev.setText(com.kwad.sdk.core.response.helper.a.cs(adInfoEM));
    }

    private static String r(long j) {
        long j2 = (j / bg.s) % 24;
        long j3 = (j / 60000) % 60;
        long j4 = (j / 1000) % 60;
        return j2 > 0 ? String.format("%02d:%02d:%02d", Long.valueOf(j2), Long.valueOf(j3), Long.valueOf(j4)) : String.format("%02d:%02d", Long.valueOf(j3), Long.valueOf(j4));
    }

    public final void a(com.kwad.components.ad.reward.g gVar, AdLiveEndResultData.AdLivePushEndInfo adLivePushEndInfo, long j) {
        this.Ex.setText(adLivePushEndInfo.mDisplayLikeUserCount);
        this.Ey.setText(r(adLivePushEndInfo.mLiveDuration));
        this.Ew.setText(adLivePushEndInfo.mDisplayWatchingUserCount);
        if (gVar.sG) {
            String str = String.format("再停留%s秒，即可获得奖励", Integer.valueOf((int) (Math.max(com.kwad.sdk.core.response.helper.a.ak(com.kwad.sdk.core.response.helper.e.eM(gVar.mAdTemplate)) - j, 0L) / 1000)));
            SpannableString spannableString = new SpannableString(str);
            int color = hZ().getResources().getColor(R.color.ksad_reward_main_color);
            spannableString.setSpan(new ForegroundColorSpan(color), 3, 6, 18);
            ForegroundColorSpan foregroundColorSpan = new ForegroundColorSpan(color);
            int length = str.length();
            spannableString.setSpan(foregroundColorSpan, length - 2, length, 18);
            this.Ez.setText(spannableString);
            return;
        }
        this.Ez.setText("内容很精彩，不要错过哦");
    }

    public final void aj(int i) {
        TextView textView = this.Ez;
        if (textView != null) {
            if (i > 0) {
                if (this.ub.sG) {
                    String str = String.format("再停留%s秒，即可获得奖励", Integer.valueOf(i));
                    SpannableString spannableString = new SpannableString(str);
                    int color = hZ().getResources().getColor(R.color.ksad_reward_main_color);
                    spannableString.setSpan(new ForegroundColorSpan(color), 3, 6, 18);
                    ForegroundColorSpan foregroundColorSpan = new ForegroundColorSpan(color);
                    int length = str.length();
                    spannableString.setSpan(foregroundColorSpan, length - 2, length, 18);
                    this.Ez.setText(spannableString);
                    return;
                }
                this.Ez.setText("已获得奖励");
                return;
            }
            textView.setText("已获得奖励");
        }
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        com.kwad.sdk.core.adlog.c.b bVar = new com.kwad.sdk.core.adlog.c.b();
        bVar.eb(24);
        if (view.equals(this.EA)) {
            this.ub.a(2, view.getContext(), 38, 1, 0L, false, bVar);
        } else if (view.equals(this.EB)) {
            this.ub.a(2, view.getContext(), 37, 1, 0L, false, bVar);
        }
    }
}
