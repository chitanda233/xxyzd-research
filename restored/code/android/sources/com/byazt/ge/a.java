package com.byazt.ge;

import android.view.View;
import com.byazt.ete.ic;
import com.byazt.fcd.x;
import com.byazt.lcf.TTBaseVideoActivity;
import com.byazt.qq.da;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, 758, 34})
public class a extends ve {
    public a(TTBaseVideoActivity tTBaseVideoActivity, ic icVar, com.byazt.kcl.tt ttVar, com.byazt.kcl.n nVar, boolean z) {
        super(tTBaseVideoActivity, icVar, ttVar, nVar, z);
    }

    @Override // com.byazt.ge.ve, com.byazt.ge.tt
    public void ve(View view) {
        super.ve(view);
        this.f943a.ve("video_player");
    }

    @Override // com.byazt.ge.ve, com.byazt.ge.tt
    public void tt(View view) {
        super.tt(view);
        if (this.f943a.to() instanceof x) {
            this.f943a.qp();
        }
        this.f943a.cu();
    }

    @Override // com.byazt.ge.ve, com.byazt.ge.tt
    public void c(View view) {
        super.c(view);
        if (c()) {
            return;
        }
        this.f943a.lt().c();
        if (this.f943a.to().to()) {
            tt();
        } else {
            ve();
        }
    }

    private void tt() {
        da daVar = new da() { // from class: com.byazt.ge.a.1
            @Override // com.byazt.qq.da
            public void tt() {
                a.this.f943a.yp();
                a.this.f943a.nb().postDelayed(new Runnable() { // from class: com.byazt.ge.a.1.1
                    @Override // java.lang.Runnable
                    public void run() {
                        a.this.f943a.tt();
                    }
                }, 100L);
            }
        };
        int i = 2;
        int iN = this.f943a.n(2);
        if (this.tt.wn() == 7) {
            if (this.tt.dh() && !this.f943a.tk()) {
                i = 1;
            }
            iN = i;
        }
        if (iN == 1) {
            if (c(daVar)) {
                return;
            }
            daVar.tt();
            return;
        }
        this.f943a.ve();
    }

    private void ve() {
        da daVar = new da() { // from class: com.byazt.ge.a.2
            @Override // com.byazt.qq.da
            public void tt() {
                a.this.f943a.ve();
            }
        };
        if (c(daVar)) {
            return;
        }
        daVar.tt();
    }

    @Override // com.byazt.ge.ve, com.byazt.ge.tt
    public void a(View view) {
        super.a(view);
        c(view);
    }

    @Override // com.byazt.ge.ve, com.byazt.ge.tt
    public void sp(View view) {
        super.sp(view);
        this.f943a.v();
    }
}
