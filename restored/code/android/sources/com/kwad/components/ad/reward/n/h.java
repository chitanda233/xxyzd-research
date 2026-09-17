package com.kwad.components.ad.reward.n;

import android.text.TextUtils;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import com.kwad.components.ad.widget.KsAppTagsView;
import com.kwad.components.core.widget.KsConvertButton;
import com.kwad.components.core.widget.KsLogoView;
import com.kwad.sdk.R;
import com.kwad.sdk.core.imageloader.KSImageLoader;

/* JADX INFO: loaded from: classes3.dex */
public class h extends s implements View.OnClickListener {
    protected ImageView CN;
    protected KsAppTagsView CR;
    protected KsConvertButton Dj;
    protected TextView Dk;
    protected TextView Dl;
    protected TextView Dm;
    protected a Dn;
    protected int Do = R.layout.ksad_reward_apk_info_card_tag_item;
    protected boolean Dp = true;
    protected KsLogoView mLogoView;

    public interface a {
        void ju();

        void jv();

        void jw();

        void jx();

        void jy();

        void jz();
    }

    public final void h(ViewGroup viewGroup) {
        super.a(viewGroup, jt(), ly());
        i(this.wL);
        if (this.wL != null) {
            this.wL.setOnClickListener(this);
            this.Dj.setOnClickListener(this);
            this.CN.setOnClickListener(this);
            this.Dk.setOnClickListener(this);
            TextView textView = this.Dl;
            if (textView != null) {
                textView.setOnClickListener(this);
            }
            TextView textView2 = this.Dm;
            if (textView2 != null) {
                textView2.setOnClickListener(this);
            }
            KsAppTagsView ksAppTagsView = this.CR;
            if (ksAppTagsView != null) {
                ksAppTagsView.setOnClickListener(this);
            }
        }
    }

    protected int jt() {
        return R.id.ksad_common_app_card_stub;
    }

    private static int ly() {
        return R.id.ksad_common_app_card_root;
    }

    private void i(ViewGroup viewGroup) {
        if (viewGroup == null) {
            return;
        }
        this.mLogoView = (KsLogoView) viewGroup.findViewById(R.id.ksad_common_app_logo);
        this.CN = (ImageView) viewGroup.findViewById(R.id.ksad_common_app_icon);
        this.Dk = (TextView) viewGroup.findViewById(R.id.ksad_common_app_name);
        this.CR = (KsAppTagsView) viewGroup.findViewById(R.id.ksad_common_app_tags);
        this.Dl = (TextView) viewGroup.findViewById(R.id.ksad_common_app_desc);
        this.Dm = (TextView) viewGroup.findViewById(R.id.ksad_common_app_desc2);
        this.Dj = (KsConvertButton) viewGroup.findViewById(R.id.ksad_common_app_action);
    }

    public final void a(a aVar) {
        this.Dn = aVar;
    }

    public final void show() {
        if (this.wL != null) {
            this.wL.setVisibility(0);
        }
    }

    @Override // com.kwad.components.ad.reward.n.d
    protected final void a(r rVar) {
        super.a(rVar);
        a(com.kwad.components.ad.reward.model.a.a(rVar, this.Dp));
    }

    /* JADX WARN: Code duplicated, block: B:32:0x0071  */
    /* JADX WARN: Code duplicated, block: B:34:0x0082  */
    /* JADX WARN: Code duplicated, block: B:38:0x008a  */
    private void a(com.kwad.components.ad.reward.model.a aVar) {
        TextView textView;
        int i;
        KsAppTagsView ksAppTagsView;
        KsConvertButton ksConvertButton;
        int i2;
        if (aVar == null) {
            return;
        }
        ai(aVar.iw());
        KsLogoView ksLogoView = this.mLogoView;
        if (ksLogoView != null) {
            ksLogoView.bh(aVar.is());
        }
        this.Dk.setText(aVar.getTitle());
        TextView textView2 = this.Dl;
        if (textView2 != null) {
            textView2.setText(aVar.hz());
        }
        TextView textView3 = this.Dm;
        if (textView3 != null) {
            textView3.setText(aVar.hz());
            if (TextUtils.isEmpty(aVar.hz())) {
                i2 = 8;
                i = 8;
            } else if (aVar.iv()) {
                i = 0;
                i2 = 8;
            } else {
                i2 = 0;
                i = 8;
            }
            TextView textView4 = this.Dl;
            if (textView4 != null) {
                textView4.setVisibility(i2);
            }
            textView = this.Dm;
        } else {
            textView = this.Dl;
            if (textView != null) {
                i = TextUtils.isEmpty(aVar.hz()) ? 8 : 0;
            }
            ksAppTagsView = this.CR;
            if (ksAppTagsView != null) {
                ksAppTagsView.a(aVar.iu(), this.Do);
                this.CR.setVisibility(aVar.iv() ? 8 : 0);
            }
            ksConvertButton = this.Dj;
            if (ksConvertButton != null) {
                ksConvertButton.a(aVar.it(), aVar.is());
            }
            KSImageLoader.loadAppIcon(this.CN, aVar.hy(), aVar.is(), 12);
        }
        textView.setVisibility(i);
        ksAppTagsView = this.CR;
        if (ksAppTagsView != null) {
            ksAppTagsView.a(aVar.iu(), this.Do);
            this.CR.setVisibility(aVar.iv() ? 8 : 0);
        }
        ksConvertButton = this.Dj;
        if (ksConvertButton != null) {
            ksConvertButton.a(aVar.it(), aVar.is());
        }
        KSImageLoader.loadAppIcon(this.CN, aVar.hy(), aVar.is(), 12);
    }

    private void ai(int i) {
        KsConvertButton ksConvertButton = this.Dj;
        if (ksConvertButton == null) {
            return;
        }
        if (i == 1) {
            ksConvertButton.getCornerConf().setAllCorner(true);
        } else if (i == 2) {
            ksConvertButton.getCornerConf().cH(false).cK(false).cJ(true).cI(true);
        }
        this.Dj.postInvalidate();
    }

    @Override // android.view.View.OnClickListener
    public void onClick(View view) {
        a aVar;
        if (view.equals(this.Dj)) {
            a aVar2 = this.Dn;
            if (aVar2 != null) {
                aVar2.ju();
                return;
            }
            return;
        }
        if (view.equals(this.CN)) {
            a aVar3 = this.Dn;
            if (aVar3 != null) {
                aVar3.jv();
                return;
            }
            return;
        }
        if (view.equals(this.Dk)) {
            a aVar4 = this.Dn;
            if (aVar4 != null) {
                aVar4.jw();
                return;
            }
            return;
        }
        if (view.equals(this.Dl) || view.equals(this.Dm)) {
            a aVar5 = this.Dn;
            if (aVar5 != null) {
                aVar5.jx();
                return;
            }
            return;
        }
        if (view.equals(this.CR)) {
            a aVar6 = this.Dn;
            if (aVar6 != null) {
                aVar6.jy();
                return;
            }
            return;
        }
        if (!view.equals(this.wL) || (aVar = this.Dn) == null) {
            return;
        }
        aVar.jz();
    }
}
