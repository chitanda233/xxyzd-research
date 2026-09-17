package com.byazt.oj;

import android.animation.ObjectAnimator;
import android.view.View;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.util.ArrayList;
import java.util.List;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 787, MediaPlayer.MEDIA_PLAYER_OPTION_DEFAULT_VIDEO_BITRATE})
public class m extends uj {
    public m(View view, com.byazt.aq.c cVar) {
        super(view, cVar);
    }

    @Override // com.byazt.oj.uj
    public List<ObjectAnimator> c() {
        ObjectAnimator duration = ObjectAnimator.ofFloat(this.ve, "translationX", 0.0f, com.byazt.or.x.c(com.byazt.sr.uj.getContext(), 20.0f), 0.0f, -com.byazt.or.x.c(com.byazt.sr.uj.getContext(), 20.0f), 0.0f).setDuration((int) (this.tt.da() * 1000.0d));
        ArrayList arrayList = new ArrayList();
        arrayList.add(c(duration));
        return arrayList;
    }
}
