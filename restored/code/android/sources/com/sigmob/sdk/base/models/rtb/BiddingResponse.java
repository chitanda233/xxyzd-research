package com.sigmob.sdk.base.models.rtb;

import android.os.Parcelable;
import com.czhj.wire.AndroidMessage;
import com.czhj.wire.FieldEncoding;
import com.czhj.wire.Message;
import com.czhj.wire.ProtoAdapter;
import com.czhj.wire.ProtoReader;
import com.czhj.wire.ProtoWriter;
import com.czhj.wire.WireField;
import com.czhj.wire.internal.Internal;
import com.czhj.wire.okio.ByteString;
import java.io.IOException;

/* JADX INFO: loaded from: classes3.dex */
public final class BiddingResponse extends AndroidMessage<BiddingResponse, Builder> {
    public static final ProtoAdapter<BiddingResponse> ADAPTER;
    public static final Parcelable.Creator<BiddingResponse> CREATOR;
    public static final String DEFAULT_CURRENCY = "";
    public static final Integer DEFAULT_ECPM;
    public static final String DEFAULT_LOSE_URL = "";
    public static final Integer DEFAULT_PRICE_FOR_SSP;
    public static final String DEFAULT_PRICE_FOR_SSP_ENC = "";
    public static final String DEFAULT_WIN_URL = "";
    private static final long serialVersionUID = 0;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#STRING", tag = 6)
    public final String currency;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#UINT32", tag = 3)
    public final Integer ecpm;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#STRING", tag = 2)
    public final String lose_url;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#UINT32", tag = 4)
    public final Integer price_for_ssp;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#STRING", tag = 5)
    public final String price_for_ssp_enc;

    @WireField(adapter = "com.squareup.wire.ProtoAdapter#STRING", tag = 1)
    public final String win_url;

    public static final class Builder extends Message.Builder<BiddingResponse, Builder> {
        public String currency;
        public Integer ecpm;
        public String lose_url;
        public Integer price_for_ssp;
        public String price_for_ssp_enc;
        public String win_url;

        @Override // com.czhj.wire.Message.Builder
        public BiddingResponse build() {
            return new BiddingResponse(this.win_url, this.lose_url, this.ecpm, this.price_for_ssp, this.price_for_ssp_enc, this.currency, super.buildUnknownFields());
        }

        public Builder currency(String currency) {
            this.currency = currency;
            return this;
        }

        public Builder ecpm(Integer ecpm) {
            this.ecpm = ecpm;
            return this;
        }

        public Builder lose_url(String lose_url) {
            this.lose_url = lose_url;
            return this;
        }

        public Builder price_for_ssp(Integer price_for_ssp) {
            this.price_for_ssp = price_for_ssp;
            return this;
        }

        public Builder price_for_ssp_enc(String price_for_ssp_enc) {
            this.price_for_ssp_enc = price_for_ssp_enc;
            return this;
        }

        public Builder win_url(String win_url) {
            this.win_url = win_url;
            return this;
        }
    }

    private static final class ProtoAdapter_BiddingResponse extends ProtoAdapter<BiddingResponse> {
        public ProtoAdapter_BiddingResponse() {
            super(FieldEncoding.LENGTH_DELIMITED, BiddingResponse.class);
        }

        /* JADX WARN: Can't rename method to resolve collision */
        @Override // com.czhj.wire.ProtoAdapter
        public BiddingResponse decode(ProtoReader reader) throws IOException {
            Builder builder = new Builder();
            long jBeginMessage = reader.beginMessage();
            while (true) {
                int iNextTag = reader.nextTag();
                if (iNextTag == -1) {
                    reader.endMessage(jBeginMessage);
                    return builder.build();
                }
                switch (iNextTag) {
                    case 1:
                        builder.win_url(ProtoAdapter.STRING.decode(reader));
                        break;
                    case 2:
                        builder.lose_url(ProtoAdapter.STRING.decode(reader));
                        break;
                    case 3:
                        builder.ecpm(ProtoAdapter.UINT32.decode(reader));
                        break;
                    case 4:
                        builder.price_for_ssp(ProtoAdapter.UINT32.decode(reader));
                        break;
                    case 5:
                        builder.price_for_ssp_enc(ProtoAdapter.STRING.decode(reader));
                        break;
                    case 6:
                        builder.currency(ProtoAdapter.STRING.decode(reader));
                        break;
                    default:
                        FieldEncoding fieldEncodingPeekFieldEncoding = reader.peekFieldEncoding();
                        builder.addUnknownField(iNextTag, fieldEncodingPeekFieldEncoding, fieldEncodingPeekFieldEncoding.rawProtoAdapter().decode(reader));
                        break;
                }
            }
        }

        @Override // com.czhj.wire.ProtoAdapter
        public void encode(ProtoWriter writer, BiddingResponse value) throws IOException {
            ProtoAdapter.STRING.encodeWithTag(writer, 1, value.win_url);
            ProtoAdapter.STRING.encodeWithTag(writer, 2, value.lose_url);
            ProtoAdapter.UINT32.encodeWithTag(writer, 3, value.ecpm);
            ProtoAdapter.UINT32.encodeWithTag(writer, 4, value.price_for_ssp);
            ProtoAdapter.STRING.encodeWithTag(writer, 5, value.price_for_ssp_enc);
            ProtoAdapter.STRING.encodeWithTag(writer, 6, value.currency);
            writer.writeBytes(value.unknownFields());
        }

        @Override // com.czhj.wire.ProtoAdapter
        public int encodedSize(BiddingResponse value) {
            return ProtoAdapter.STRING.encodedSizeWithTag(1, value.win_url) + ProtoAdapter.STRING.encodedSizeWithTag(2, value.lose_url) + ProtoAdapter.UINT32.encodedSizeWithTag(3, value.ecpm) + ProtoAdapter.UINT32.encodedSizeWithTag(4, value.price_for_ssp) + ProtoAdapter.STRING.encodedSizeWithTag(5, value.price_for_ssp_enc) + ProtoAdapter.STRING.encodedSizeWithTag(6, value.currency) + value.unknownFields().size();
        }

        @Override // com.czhj.wire.ProtoAdapter
        public BiddingResponse redact(BiddingResponse value) {
            Builder builderNewBuilder = value.newBuilder();
            builderNewBuilder.clearUnknownFields();
            return builderNewBuilder.build();
        }
    }

    static {
        ProtoAdapter_BiddingResponse protoAdapter_BiddingResponse = new ProtoAdapter_BiddingResponse();
        ADAPTER = protoAdapter_BiddingResponse;
        CREATOR = AndroidMessage.newCreator(protoAdapter_BiddingResponse);
        DEFAULT_ECPM = 0;
        DEFAULT_PRICE_FOR_SSP = 0;
    }

    public BiddingResponse(String win_url, String lose_url, Integer ecpm, Integer price_for_ssp, String price_for_ssp_enc, String currency) {
        this(win_url, lose_url, ecpm, price_for_ssp, price_for_ssp_enc, currency, ByteString.EMPTY);
    }

    public BiddingResponse(String win_url, String lose_url, Integer ecpm, Integer price_for_ssp, String price_for_ssp_enc, String currency, ByteString unknownFields) {
        super(ADAPTER, unknownFields);
        this.win_url = win_url;
        this.lose_url = lose_url;
        this.ecpm = ecpm;
        this.price_for_ssp = price_for_ssp;
        this.price_for_ssp_enc = price_for_ssp_enc;
        this.currency = currency;
    }

    public boolean equals(Object other) {
        if (other == this) {
            return true;
        }
        if (!(other instanceof BiddingResponse)) {
            return false;
        }
        BiddingResponse biddingResponse = (BiddingResponse) other;
        return unknownFields().equals(biddingResponse.unknownFields()) && Internal.equals(this.win_url, biddingResponse.win_url) && Internal.equals(this.lose_url, biddingResponse.lose_url) && Internal.equals(this.ecpm, biddingResponse.ecpm) && Internal.equals(this.price_for_ssp, biddingResponse.price_for_ssp) && Internal.equals(this.price_for_ssp_enc, biddingResponse.price_for_ssp_enc) && Internal.equals(this.currency, biddingResponse.currency);
    }

    public int hashCode() {
        int i = this.hashCode;
        if (i != 0) {
            return i;
        }
        int iHashCode = unknownFields().hashCode() * 37;
        String str = this.win_url;
        int iHashCode2 = (iHashCode + (str != null ? str.hashCode() : 0)) * 37;
        String str2 = this.lose_url;
        int iHashCode3 = (iHashCode2 + (str2 != null ? str2.hashCode() : 0)) * 37;
        Integer num = this.ecpm;
        int iHashCode4 = (iHashCode3 + (num != null ? num.hashCode() : 0)) * 37;
        Integer num2 = this.price_for_ssp;
        int iHashCode5 = (iHashCode4 + (num2 != null ? num2.hashCode() : 0)) * 37;
        String str3 = this.price_for_ssp_enc;
        int iHashCode6 = (iHashCode5 + (str3 != null ? str3.hashCode() : 0)) * 37;
        String str4 = this.currency;
        int iHashCode7 = iHashCode6 + (str4 != null ? str4.hashCode() : 0);
        this.hashCode = iHashCode7;
        return iHashCode7;
    }

    @Override // com.czhj.wire.Message
    public Builder newBuilder() {
        Builder builder = new Builder();
        builder.win_url = this.win_url;
        builder.lose_url = this.lose_url;
        builder.ecpm = this.ecpm;
        builder.price_for_ssp = this.price_for_ssp;
        builder.price_for_ssp_enc = this.price_for_ssp_enc;
        builder.currency = this.currency;
        builder.addUnknownFields(unknownFields());
        return builder;
    }

    @Override // com.czhj.wire.Message
    public String toString() {
        StringBuilder sb = new StringBuilder();
        if (this.win_url != null) {
            sb.append(", win_url=").append(this.win_url);
        }
        if (this.lose_url != null) {
            sb.append(", lose_url=").append(this.lose_url);
        }
        if (this.ecpm != null) {
            sb.append(", ecpm=").append(this.ecpm);
        }
        if (this.price_for_ssp != null) {
            sb.append(", price_for_ssp=").append(this.price_for_ssp);
        }
        if (this.price_for_ssp_enc != null) {
            sb.append(", price_for_ssp_enc=").append(this.price_for_ssp_enc);
        }
        if (this.currency != null) {
            sb.append(", currency=").append(this.currency);
        }
        return sb.replace(0, 2, "BiddingResponse{").append('}').toString();
    }
}
