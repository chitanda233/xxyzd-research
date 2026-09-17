package com.kwad.components.ad.reward.widget;

import android.content.Context;
import android.util.AttributeSet;
import android.view.View;
import android.widget.ImageView;
import android.widget.ProgressBar;
import android.widget.TextView;
import com.kwad.sdk.R;
import com.kwad.sdk.widget.KSFrameLayout;

/* JADX INFO: loaded from: classes3.dex */
public class RewardPreviewTopBarView extends KSFrameLayout implements View.OnClickListener {
    private boolean FA;
    private a FB;
    private String Fu;
    private String Fv;
    private ProgressBar Fw;
    private TextView Fx;
    private long Fy;
    private long Fz;
    private ImageView cH;
    private TextView wM;

    public interface a {
        void H(boolean z);

        void I(boolean z);
    }

    public RewardPreviewTopBarView(Context context) {
        super(context);
        this.Fu = " 秒后即可获得奖励";
        this.Fv = "恭喜你获得奖励";
        this.Fy = -1L;
        this.FA = false;
    }

    public RewardPreviewTopBarView(Context context, AttributeSet attributeSet) {
        super(context, attributeSet);
        this.Fu = " 秒后即可获得奖励";
        this.Fv = "恭喜你获得奖励";
        this.Fy = -1L;
        this.FA = false;
    }

    public RewardPreviewTopBarView(Context context, AttributeSet attributeSet, int i) {
        super(context, attributeSet, i);
        this.Fu = " 秒后即可获得奖励";
        this.Fv = "恭喜你获得奖励";
        this.Fy = -1L;
        this.FA = false;
    }

    @Override // com.kwad.sdk.widget.KSFrameLayout
    public final void init(Context context, AttributeSet attributeSet) {
        super.init(context, attributeSet);
        inflate(getContext(), R.layout.ksad_activity_preview_topbar, this);
        this.Fw = (ProgressBar) findViewById(R.id.ksad_preview_topbar_progress);
        this.wM = (TextView) findViewById(R.id.ksad_preview_topbar_reward_tips);
        this.Fx = (TextView) findViewById(R.id.ksad_preview_topbar_reward_count);
        ImageView imageView = (ImageView) findViewById(R.id.ksad_preview_topbar_close);
        this.cH = imageView;
        imageView.setVisibility(8);
        this.cH.setOnClickListener(this);
    }

    public void setRewardTips(String str) {
        TextView textView = this.wM;
        if (textView == null || str == null) {
            return;
        }
        textView.setText(str);
    }

    public void setCloseBtnDelayShowDuration(long j) {
        this.Fz = j;
        if (j <= 0) {
            this.cH.setVisibility(0);
        }
    }

    public void setTotalCountDuration(long j) {
        this.Fy = j;
        this.Fw.setMax((int) j);
    }

    public void setTopBarListener(a aVar) {
        this.FB = aVar;
    }

    public final void s(long j) {
        int iCeil = (int) Math.ceil(j / 1000.0f);
        TextView textView = this.Fx;
        if (textView != null) {
            textView.setText(iCeil + this.Fu);
        }
        e(j, this.Fy);
        if (this.Fy - j >= this.Fz && this.cH.getVisibility() != 0) {
            this.cH.setVisibility(0);
        }
        if (iCeil <= 0) {
            f(true, false);
        }
    }

    public final boolean lH() {
        return this.FA;
    }

    private void f(boolean z, boolean z2) {
        if (!this.FA) {
            this.wM.setVisibility(8);
            this.Fx.setText(this.Fv);
            a aVar = this.FB;
            if (aVar != null) {
                aVar.I(false);
            }
        } else {
            this.wM.setVisibility(0);
        }
        this.FA = true;
    }

    private void e(long j, long j2) {
        this.Fw.setProgress((int) (j2 - j));
    }

    @Override // android.view.View.OnClickListener
    public void onClick(View view) {
        a aVar;
        if (!view.equals(this.cH) || (aVar = this.FB) == null) {
            return;
        }
        aVar.H(this.FA);
    }
}
