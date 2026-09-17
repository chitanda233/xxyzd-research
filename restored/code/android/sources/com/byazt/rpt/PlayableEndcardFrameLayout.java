package com.byazt.rpt;

import android.content.Context;
import android.view.MotionEvent;
import android.widget.FrameLayout;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_START_DIRECTLLY_AFTER_PREPARED, 445})
public class PlayableEndcardFrameLayout extends FrameLayout {
    public c c;
    public int tt;

    public interface c {
        void c();
    }

    public PlayableEndcardFrameLayout(Context context) {
        super(context);
    }

    public void c(c cVar) {
        this.c = cVar;
    }

    @Override // android.view.ViewGroup, android.view.View
    public boolean dispatchTouchEvent(MotionEvent motionEvent) {
        int y = (int) motionEvent.getY();
        int action = motionEvent.getAction();
        if (action != 0) {
            if (action == 2 && Math.abs(this.tt - y) > 100) {
                c();
                this.tt = y;
            }
        } else {
            this.tt = y;
        }
        return super.dispatchTouchEvent(motionEvent);
    }

    private void c() {
        c cVar = this.c;
        if (cVar != null) {
            cVar.c();
        }
    }
}
