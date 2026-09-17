package com.kwad.components.core.e.e;

import android.view.View;
import android.widget.TextView;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.kwad.sdk.R;

/* JADX INFO: loaded from: classes3.dex */
public final class d extends b implements View.OnClickListener {
    private TextView RF;
    private TextView RG;
    private TextView uB;

    @Override // com.kwad.sdk.mvp.Presenter
    public final void onCreate() {
        super.onCreate();
        this.uB = (TextView) findViewById(R.id.ksad_second_confirm_content_view);
        this.RF = (TextView) findViewById(R.id.ksad_second_confirm_ensure);
        this.RG = (TextView) findViewById(R.id.ksad_second_confirm_cancle);
    }

    @Override // com.kwad.components.core.e.e.b, com.kwad.sdk.mvp.Presenter
    public final void av() {
        super.av();
        if (this.RE.RD.pP() == 1) {
            this.uB.setText("即将打开" + com.kwad.sdk.core.response.helper.a.ct(this.mAdInfo));
        } else if (this.RE.RD.pP() == 2) {
            this.uB.setText("即将打开第三方页面");
        }
        com.kwad.sdk.c.a.a.a(this, this.RF, this.RG);
    }

    @Override // android.view.View.OnClickListener
    public final void onClick(View view) {
        this.RE.RD.ao(true);
        this.RE.RB.dismiss();
        if (view == this.RF) {
            com.kwad.components.core.e.d.a.a(this.RE.RD);
            com.kwad.sdk.core.adlog.c.s(this.RE.RD.getAdTemplate(), MediaPlayer.MEDIA_PLAYER_OPTION_NETWORK_TRY_COUNT);
        } else if (view == this.RG) {
            com.kwad.sdk.core.adlog.c.s(this.RE.RD.getAdTemplate(), MediaPlayer.MEDIA_PLAYER_OPTION_ALOG_WRITE_FUNC_ADDR);
        }
    }
}
