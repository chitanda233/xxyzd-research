package com.kwad.components.ad.reward;

import android.app.Activity;
import android.app.DialogFragment;
import android.content.Context;
import android.content.DialogInterface;
import android.graphics.drawable.ColorDrawable;
import android.os.Bundle;
import android.text.SpannableString;
import android.text.TextUtils;
import android.text.style.ForegroundColorSpan;
import android.text.style.StyleSpan;
import android.view.KeyEvent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.components.ad.reward.widget.RewardTaskStepView;
import com.kwad.components.core.widget.KSCornerImageView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdMatrixInfo;
import com.kwad.sdk.core.response.model.AdProductInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.ac;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class h extends com.kwad.components.core.proxy.j {
    private static String tB = "进阶奖励还差 %s 步到手，\n确认放弃吗？";
    private static String tC = "再观看%ss可获得基础奖励，\n确认放弃吗？";
    private AdTemplate mAdTemplate;
    private a tA;

    public interface a extends com.kwad.components.core.webview.tachikoma.f.c {
        void h(int i, int i2);

        void hr();
    }

    public static class b implements a {
        @Override // com.kwad.components.core.webview.tachikoma.f.c
        public void H(boolean z) {
        }

        @Override // com.kwad.components.ad.reward.h.a
        public void h(int i, int i2) {
        }

        @Override // com.kwad.components.core.webview.tachikoma.f.c
        public void hk() {
        }

        @Override // com.kwad.components.ad.reward.h.a
        public void hr() {
        }

        @Override // com.kwad.components.core.webview.tachikoma.f.c
        public void hs() {
        }

        @Override // com.kwad.components.core.webview.tachikoma.f.c
        public void ht() {
        }
    }

    public static c g(String str, int i) {
        return c.h(str, i);
    }

    public static c a(g gVar, String str) {
        int i;
        AdTemplate adTemplate = gVar.mAdTemplate;
        AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
        com.kwad.components.ad.reward.l.b.a aVar = gVar.ta;
        com.kwad.components.ad.reward.l.a.a aVar2 = gVar.tb;
        int i2 = gVar.tc;
        boolean zM = com.kwad.sdk.core.response.helper.e.m(adTemplate, com.kwad.components.ad.reward.a.b.l(com.kwad.sdk.core.response.helper.e.eM(adTemplate)));
        int i3 = 0;
        if (zM || com.kwad.sdk.core.response.helper.e.O(adTemplate)) {
            int iAg = (int) com.kwad.sdk.core.response.helper.a.ag(adInfoEM);
            int iN = com.kwad.sdk.core.response.helper.a.N(adInfoEM);
            if (iAg > iN) {
                iAg = iN;
            }
            long playDuration = gVar.sr.getPlayDuration();
            if (playDuration < (iAg * 1000) - 800 && (i = (int) (iAg - ((playDuration / 1000.0f) + 0.5f))) >= 0) {
                i3 = i;
            }
        }
        if (zM && aVar != null) {
            return c.a(aVar, adTemplate, String.valueOf(i3));
        }
        if (com.kwad.sdk.core.response.helper.e.O(adTemplate) && aVar2 != null) {
            return c.a(aVar2, adTemplate, String.valueOf(i3));
        }
        if (com.kwad.components.ad.reward.a.b.j(adInfoEM)) {
            return c.i(adInfoEM);
        }
        if (com.kwad.sdk.core.response.helper.a.cq(adInfoEM) == 1 && com.kwad.components.ad.reward.a.b.hT() == 1) {
            return c.a(adInfoEM, i2);
        }
        if (adTemplate.isNativeRewardPreview) {
            return c.h(str, i2);
        }
        if (com.kwad.sdk.core.response.helper.a.cY(adInfoEM)) {
            return c.c(adTemplate, i2);
        }
        if (com.kwad.sdk.core.response.helper.a.cI(adTemplate)) {
            return c.d(adTemplate, i2);
        }
        if (com.kwad.components.ad.reward.a.b.hN() == 1) {
            return c.n(i2);
        }
        return c.D(str);
    }

    public static h a(Activity activity, AdTemplate adTemplate, c cVar, a aVar) {
        h hVar = new h();
        Bundle bundle = new Bundle();
        bundle.putString("key_params_json", cVar.toJson().toString());
        bundle.putString("key_template_json", adTemplate.toJson().toString());
        hVar.setArguments(bundle);
        hVar.a(aVar);
        hVar.show(activity.getFragmentManager(), "videoCloseDialog");
        return hVar;
    }

    private void a(a aVar) {
        this.tA = aVar;
    }

    @Override // com.kwad.components.core.proxy.j
    public final View a(LayoutInflater layoutInflater, ViewGroup viewGroup) {
        View viewA;
        Bundle arguments = getArguments();
        String string = arguments.getString("key_params_json");
        try {
            String string2 = arguments.getString("key_template_json");
            AdTemplate adTemplate = new AdTemplate();
            this.mAdTemplate = adTemplate;
            adTemplate.parseJson(new JSONObject(string2));
        } catch (Throwable unused) {
        }
        c cVarE = c.E(string);
        int style = cVarE.getStyle();
        if (style == 1) {
            viewA = a(this, layoutInflater, viewGroup, cVarE, this.mAdTemplate, this.tA);
        } else if (style == 2) {
            viewA = b(this, layoutInflater, viewGroup, cVarE, this.mAdTemplate, this.tA);
        } else if (style == 4) {
            viewA = c(this, layoutInflater, viewGroup, cVarE, this.mAdTemplate, this.tA);
            com.kwad.components.core.t.m.a(new com.kwad.components.core.widget.e(), (ViewGroup) viewA);
        } else if (style == 5) {
            com.kwad.components.ad.reward.n.j jVar = new com.kwad.components.ad.reward.n.j(this, this.mAdTemplate, layoutInflater, viewGroup, this.tA);
            jVar.a(cVarE);
            viewA = jVar.hZ();
        } else if (style == 6) {
            viewA = a(this, layoutInflater, viewGroup, cVarE, this.tA);
        } else if (style == 8) {
            com.kwad.components.ad.reward.n.m mVar = new com.kwad.components.ad.reward.n.m(this, this.mAdTemplate, layoutInflater, viewGroup, this.tA);
            mVar.a(cVarE);
            viewA = mVar.hZ();
        } else {
            viewA = a((DialogFragment) this, layoutInflater, viewGroup, cVarE, this.tA);
        }
        getDialog().setOnKeyListener(new DialogInterface.OnKeyListener() { // from class: com.kwad.components.ad.reward.h.1
            @Override // android.content.DialogInterface.OnKeyListener
            public final boolean onKey(DialogInterface dialogInterface, int i, KeyEvent keyEvent) {
                return i == 4 && keyEvent.getAction() == 0;
            }
        });
        return viewA;
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
        a aVar = this.tA;
        if (aVar != null) {
            aVar.hk();
        }
    }

    private static View a(final DialogFragment dialogFragment, LayoutInflater layoutInflater, ViewGroup viewGroup, c cVar, final a aVar) {
        View viewInflate = layoutInflater.inflate(R.layout.ksad_video_close_dialog, viewGroup, false);
        ((TextView) viewInflate.findViewById(R.id.ksad_title)).setText(cVar.getTitle());
        TextView textView = (TextView) viewInflate.findViewById(R.id.ksad_close_btn);
        TextView textView2 = (TextView) viewInflate.findViewById(R.id.ksad_continue_btn);
        textView.setText(cVar.hu());
        textView2.setText(cVar.hv());
        textView.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.reward.h.3
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                dialogFragment.dismiss();
                a aVar2 = aVar;
                if (aVar2 != null) {
                    aVar2.H(false);
                }
            }
        });
        textView2.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.reward.h.4
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                dialogFragment.dismiss();
                a aVar2 = aVar;
                if (aVar2 != null) {
                    aVar2.ht();
                }
            }
        });
        return viewInflate;
    }

    private View a(final h hVar, LayoutInflater layoutInflater, ViewGroup viewGroup, c cVar, final a aVar) {
        View viewInflate = layoutInflater.inflate(R.layout.ksad_video_close_extend_dialog, viewGroup, false);
        ((TextView) viewInflate.findViewById(R.id.ksad_reward_close_extend_dialog_play_time_tips)).setText(f(viewInflate.getContext(), cVar.tO));
        TextView textView = (TextView) viewInflate.findViewById(R.id.ksad_reward_close_extend_dialog_btn_deny);
        TextView textView2 = (TextView) viewInflate.findViewById(R.id.ksad_reward_close_extend_dialog_btn_continue);
        textView.setText(cVar.hu());
        textView2.setText(cVar.hv());
        textView.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.reward.h.5
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                hVar.dismiss();
                a aVar2 = aVar;
                if (aVar2 != null) {
                    aVar2.H(false);
                }
            }
        });
        textView2.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.reward.h.6
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                hVar.dismiss();
                a aVar2 = aVar;
                if (aVar2 != null) {
                    aVar2.ht();
                }
            }
        });
        return viewInflate;
    }

    private static SpannableString f(Context context, String str) {
        SpannableString spannableString = new SpannableString("再看" + str + "秒，即可获得奖励");
        ForegroundColorSpan foregroundColorSpan = new ForegroundColorSpan(com.kwad.sdk.c.a.a.getColor(context, R.color.ksad_reward_main_color));
        ForegroundColorSpan foregroundColorSpan2 = new ForegroundColorSpan(com.kwad.sdk.c.a.a.getColor(context, R.color.ksad_reward_main_color));
        StyleSpan styleSpan = new StyleSpan(1);
        int length = spannableString.length();
        spannableString.setSpan(foregroundColorSpan, 2, length - 7, 34);
        spannableString.setSpan(foregroundColorSpan2, length - 2, length, 34);
        spannableString.setSpan(styleSpan, 0, length, 34);
        return spannableString;
    }

    private static View a(com.kwad.components.ad.reward.l.a aVar, final DialogFragment dialogFragment, LayoutInflater layoutInflater, ViewGroup viewGroup, c cVar, AdTemplate adTemplate, final a aVar2) {
        String str;
        int i;
        View viewInflate = layoutInflater.inflate(R.layout.ksad_reward_task_launch_app_dialog, viewGroup, false);
        if (aVar instanceof com.kwad.components.ad.reward.l.b.a) {
            com.kwad.components.ad.reward.l.b.a.a((com.kwad.components.ad.reward.l.b.a) aVar, viewInflate.getContext(), adTemplate);
        }
        ((RewardTaskStepView) viewInflate.findViewById(R.id.ksad_reward_task_dialog_steps)).a(aVar.kU(), cVar.tK);
        KSImageLoader.loadAppIcon((ImageView) viewInflate.findViewById(R.id.ksad_reward_task_dialog_icon), cVar.hy(), adTemplate, 12);
        TextView textView = (TextView) viewInflate.findViewById(R.id.ksad_reward_task_dialog_abandon);
        TextView textView2 = (TextView) viewInflate.findViewById(R.id.ksad_reward_task_dialog_continue);
        TextView textView3 = (TextView) viewInflate.findViewById(R.id.ksad_reward_task_dialog_title);
        String string = new StringBuilder().append(aVar.kV()).toString();
        String str2 = cVar.tK;
        boolean zEquals = "0".equals(str2);
        if (zEquals) {
            str = String.format(tB, string);
        } else {
            str = String.format(tC, str2);
        }
        int iIndexOf = zEquals ? str.indexOf(string) : str.indexOf(str2);
        if (iIndexOf < 0) {
            textView3.setText(str);
        } else {
            if (zEquals) {
                i = iIndexOf + 1;
            } else {
                i = str2.length() > 1 ? iIndexOf + 3 : iIndexOf + 2;
            }
            ForegroundColorSpan foregroundColorSpan = new ForegroundColorSpan(viewInflate.getContext().getResources().getColor(R.color.ksad_reward_main_color));
            SpannableString spannableString = new SpannableString(str);
            spannableString.setSpan(foregroundColorSpan, iIndexOf, i, 17);
            textView3.setText(spannableString);
        }
        textView.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.reward.h.7
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                dialogFragment.dismiss();
                a aVar3 = aVar2;
                if (aVar3 != null) {
                    aVar3.H(false);
                }
            }
        });
        textView2.setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.reward.h.8
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                dialogFragment.dismiss();
                a aVar3 = aVar2;
                if (aVar3 != null) {
                    aVar3.ht();
                }
            }
        });
        return viewInflate;
    }

    private static View a(DialogFragment dialogFragment, LayoutInflater layoutInflater, ViewGroup viewGroup, c cVar, AdTemplate adTemplate, a aVar) {
        return a(cVar.hw(), dialogFragment, layoutInflater, viewGroup, cVar, adTemplate, aVar);
    }

    private static View b(DialogFragment dialogFragment, LayoutInflater layoutInflater, ViewGroup viewGroup, c cVar, AdTemplate adTemplate, a aVar) {
        return a(cVar.hx(), dialogFragment, layoutInflater, viewGroup, cVar, adTemplate, aVar);
    }

    private static View c(final DialogFragment dialogFragment, LayoutInflater layoutInflater, ViewGroup viewGroup, c cVar, AdTemplate adTemplate, final a aVar) {
        View viewInflate = layoutInflater.inflate(R.layout.ksad_reward_order_dialog, viewGroup, false);
        KSImageLoader.loadImage((KSCornerImageView) viewInflate.findViewById(R.id.ksad_reward_order_dialog_icon), cVar.tL, adTemplate);
        ((TextView) viewInflate.findViewById(R.id.ksad_reward_order_dialog_desc)).setText(cVar.getTitle());
        viewInflate.findViewById(R.id.ksad_reward_order_dialog_btn_close).setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.reward.h.9
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                dialogFragment.dismiss();
                a aVar2 = aVar;
                if (aVar2 != null) {
                    aVar2.ht();
                }
            }
        });
        viewInflate.findViewById(R.id.ksad_reward_order_dialog_btn_view_detail).setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.reward.h.10
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                a aVar2 = aVar;
                if (aVar2 != null) {
                    aVar2.hr();
                }
            }
        });
        viewInflate.findViewById(R.id.ksad_reward_order_dialog_btn_deny).setOnClickListener(new View.OnClickListener() { // from class: com.kwad.components.ad.reward.h.2
            @Override // android.view.View.OnClickListener
            public final void onClick(View view) {
                dialogFragment.dismiss();
                a aVar2 = aVar;
                if (aVar2 != null) {
                    aVar2.H(false);
                }
            }
        });
        return viewInflate;
    }

    public static class c extends com.kwad.sdk.core.response.a.a {
        public int style;
        public String tH;
        public String tI;
        public String tJ;
        public String tK;
        public String tL;
        public String tM;
        public String tN;
        public String tO;
        public com.kwad.components.ad.reward.l.b.a ta;
        public com.kwad.components.ad.reward.l.a.a tb;
        public String title;

        private c() {
        }

        static c D(String str) {
            c cVar = new c();
            cVar.style = 0;
            cVar.title = str;
            cVar.tH = "关闭广告";
            cVar.tI = "继续观看";
            return cVar;
        }

        static c n(long j) {
            c cVar = new c();
            cVar.style = 6;
            cVar.tH = "残忍离开";
            cVar.tI = "留下看看";
            if (j > 0) {
                cVar.F(String.valueOf(j));
            } else {
                cVar.F(null);
            }
            return cVar;
        }

        static c c(AdTemplate adTemplate, long j) {
            AdInfo adInfoEM = com.kwad.sdk.core.response.helper.e.eM(adTemplate);
            c cVar = new c();
            cVar.style = 8;
            cVar.tL = com.kwad.sdk.core.response.helper.a.cv(adInfoEM);
            cVar.title = String.format("再看%s秒，可获得奖励", Long.valueOf(j));
            cVar.tM = com.kwad.sdk.core.response.helper.a.cs(adInfoEM);
            cVar.tN = com.kwad.sdk.core.response.helper.a.aA(adInfoEM);
            cVar.tH = "放弃奖励";
            cVar.tI = "继续观看";
            cVar.tJ = com.kwad.sdk.core.response.helper.a.aK(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
            return cVar;
        }

        static c d(AdTemplate adTemplate, long j) {
            AdMatrixInfo.MerchantLiveReservationInfo merchantLiveReservationInfoDP = com.kwad.sdk.core.response.helper.b.dP(adTemplate);
            c cVar = new c();
            cVar.style = 8;
            cVar.tL = merchantLiveReservationInfoDP.userHeadUrl;
            cVar.title = String.format("再看%s秒，可获得奖励", Long.valueOf(j));
            cVar.tM = merchantLiveReservationInfoDP.title;
            cVar.tH = "放弃奖励";
            cVar.tI = "继续观看";
            cVar.tJ = com.kwad.sdk.core.response.helper.a.aK(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
            return cVar;
        }

        public static c h(String str, int i) {
            c cVar = new c();
            cVar.style = 6;
            cVar.title = str;
            cVar.tH = "残忍离开";
            cVar.tI = "留下看看";
            if (i > 0) {
                cVar.tO = String.valueOf(i);
            }
            return cVar;
        }

        static c a(com.kwad.components.ad.reward.l.b.a aVar, AdTemplate adTemplate, String str) {
            c cVar = new c();
            cVar.style = 1;
            cVar.ta = aVar;
            cVar.tK = str;
            cVar.tL = com.kwad.sdk.core.response.helper.a.cv(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
            return cVar;
        }

        static c a(com.kwad.components.ad.reward.l.a.a aVar, AdTemplate adTemplate, String str) {
            c cVar = new c();
            cVar.style = 2;
            cVar.tb = aVar;
            cVar.tK = str;
            cVar.tL = com.kwad.sdk.core.response.helper.a.cv(com.kwad.sdk.core.response.helper.e.eM(adTemplate));
            return cVar;
        }

        static c i(AdInfo adInfo) {
            c cVar = new c();
            cVar.style = 4;
            AdProductInfo adProductInfoDc = com.kwad.sdk.core.response.helper.a.dc(adInfo);
            cVar.title = com.kwad.sdk.core.response.helper.a.aA(adInfo);
            cVar.tL = adProductInfoDc.getIcon();
            return cVar;
        }

        public static c a(AdInfo adInfo, long j) {
            c cVar = new c();
            cVar.style = 5;
            AdProductInfo adProductInfoDc = com.kwad.sdk.core.response.helper.a.dc(adInfo);
            cVar.tM = com.kwad.sdk.core.response.helper.a.aA(adInfo);
            String name = adProductInfoDc.getName();
            cVar.title = name;
            if (TextUtils.isEmpty(name)) {
                cVar.title = com.kwad.sdk.core.response.helper.a.aD(adInfo);
            }
            cVar.tL = adProductInfoDc.getIcon();
            if (j > 0) {
                cVar.F(String.valueOf(j));
            } else {
                cVar.F(null);
            }
            return cVar;
        }

        public static c E(String str) {
            c cVar = new c();
            try {
                cVar.parseJson(new JSONObject(str));
            } catch (JSONException unused) {
            }
            return cVar;
        }

        public final int getStyle() {
            return this.style;
        }

        public final String getTitle() {
            return this.title;
        }

        public final String hu() {
            return TextUtils.isEmpty(this.tH) ? "关闭广告" : this.tH;
        }

        public final String hv() {
            return TextUtils.isEmpty(this.tI) ? "继续观看" : this.tI;
        }

        public final com.kwad.components.ad.reward.l.b.a hw() {
            return this.ta;
        }

        public final com.kwad.components.ad.reward.l.a.a hx() {
            return this.tb;
        }

        public final String hy() {
            return this.tL;
        }

        public final String hz() {
            return this.tM;
        }

        public final String hA() {
            return this.tN;
        }

        public final String hB() {
            return TextUtils.isEmpty(this.tO) ? "" : String.format("再看%s秒，可获得优惠", this.tO);
        }

        private void F(String str) {
            this.tO = str;
        }

        @Override // com.kwad.sdk.core.response.a.a
        public void afterParseJson(JSONObject jSONObject) {
            super.afterParseJson(jSONObject);
            JSONObject jSONObjectOptJSONObject = jSONObject.optJSONObject("mLaunchAppTask");
            if (jSONObjectOptJSONObject != null) {
                if (this.ta == null) {
                    this.ta = new com.kwad.components.ad.reward.l.b.a();
                }
                this.ta.parseJson(jSONObjectOptJSONObject);
            }
            JSONObject jSONObjectOptJSONObject2 = jSONObject.optJSONObject("mLandPageOpenTask");
            if (jSONObjectOptJSONObject2 != null) {
                if (this.tb == null) {
                    this.tb = new com.kwad.components.ad.reward.l.a.a();
                }
                this.tb.parseJson(jSONObjectOptJSONObject2);
            }
        }

        @Override // com.kwad.sdk.core.response.a.a
        public void afterToJson(JSONObject jSONObject) {
            super.afterToJson(jSONObject);
            com.kwad.components.ad.reward.l.b.a aVar = this.ta;
            if (aVar != null) {
                ac.a(jSONObject, "mLaunchAppTask", aVar);
            }
            com.kwad.components.ad.reward.l.a.a aVar2 = this.tb;
            if (aVar2 != null) {
                ac.a(jSONObject, "mLandPageOpenTask", aVar2);
            }
        }
    }
}
